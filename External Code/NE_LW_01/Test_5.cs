using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CBF = NE_DLL.NE_Bessel_Functions;
using CGQ = NE_DLL.MAC_Gauss_Quadrature;
using System.Diagnostics;
namespace NE_LW_01_Test_5
{
  class Test_5
  {
    static double alpha = 0.7, betta = 0.5, appr_value, true_value, error;
    static int n = 1; static string title = "AB_11_4_36";

    static void Main(string[] args)     // alpha > betta   n > 0    !
    {
      using (StreamWriter SW = new StreamWriter("Test_5.txt", true))
      {
        CGQ gauss = new CGQ(32); Stopwatch clock = new Stopwatch(); clock.Start();

        appr_value = gauss.Improper(0.0, AB_11_4_36, 1.0E-8, out double B);
        True_Value(); error = Math.Abs(true_value - appr_value); clock.Stop();

        SW.WriteLine($" {title}  time = {clock.ElapsedMilliseconds / 1000} sec");
        SW.WriteLine($"  appr = {appr_value,22:F16}  B ={B,12:F1}");
        SW.WriteLine($" value = {true_value,22:F16}\r\n error = {error,22:F16}\r\n");
      }
    }
    static double AB_11_4_36(double t) => CBF.Jn(n, alpha * t) * Math.Cos(betta * t) / t;
    static void True_Value()
    {
      if (alpha > betta) true_value = Math.Cos(n * Math.Asin(betta / alpha)) / n;
      else
      {
        true_value = Math.Cos(Math.PI * n / 2) / n;
        true_value *= Math.Pow(alpha / (betta + Math.Sqrt(betta * betta - alpha * alpha)), n);
      }
    }
  }
}
