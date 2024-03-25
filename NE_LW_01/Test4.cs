using System;
using System.IO;
using CGQ = NE_DLL.MAC_Gauss_Quadrature;
using System.Diagnostics;
using System.ComponentModel;

namespace NE_LW_01
{
    class Test_4
    {
        static double alpha, beta, appr_value, true_value, error, B;
        static int n, m; 
        
        static string title = "";

        static void Write(string fileName, Action<CGQ> code)
        {
            using (StreamWriter SW = new StreamWriter(fileName, true))
            {
                CGQ gauss = new CGQ(32);
                Stopwatch clock = new Stopwatch();

                clock.Start();

                code(gauss);
              

                clock.Stop();
                SW.WriteLine($" {title}  time = {clock.ElapsedMilliseconds} millisec");
                SW.WriteLine($"  appr = {appr_value,22:F16}  B ={B,12:F1}");
                SW.WriteLine($" value = {true_value,22:F16}");
                SW.WriteLine($" error = {error,22:F16}\r\n");
            }
        }

        public static void Run(string fileName)
        {
            using(StreamWriter SW = new StreamWriter(fileName)) {

            }
            Write(fileName, (CGQ gauss) =>
            {
                title = "DW_856_31"; alpha = 0.7; beta = 0.5; // alpha > betta 
                appr_value = gauss.Improper(0.0, DW_856_31, 1.0E-13, out B);
                true_value = 0.5 * Math.PI / alpha / beta / (alpha + beta);
                error = Math.Abs(true_value - appr_value);
            });
            Write(fileName, (CGQ gauss) =>
            {
                title = "DW_858_711"; n = 3; m = 2; // n > m
                appr_value = gauss.Improper(0.0, DW_858_711, 1.0E-13, out B);
                true_value = 0.5 * Math.PI * m;
                error = Math.Abs(true_value - appr_value);
            });
            Write(fileName, (CGQ gauss) =>
            {
                title = "DW_859_005"; m = 2; alpha = 1.7;
                appr_value = gauss.Improper(0.0, DW_859_005, 1.0E-13, out B);
                true_value = Math.PI / 2 / alpha / alpha * (1.0 - Math.Exp(-m * alpha));
                error = Math.Abs(true_value - appr_value);
            });

        }
        static double DW_856_31(double x)
        {
            return 1.0 / (alpha * alpha + x * x) / (beta * beta + x * x); 
        }
        static double DW_858_711(double x)
        { 
            return (Math.Sin(m * x) / x) * (Math.Sin(n * x) / x); 
        }
        static double DW_859_005(double x)
        { 
            return Math.Sin(m * x) / (alpha * alpha + x * x) / x;
        }
    }
}
