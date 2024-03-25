using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CBF = NE_DLL.NE_Bessel_Functions;
namespace NE_LW_01_Test_3
{
  class Test_3
  {
    static void Main(string[] args)
    {
      const int n0 = 0, n1 = 1, n2 = 2; double x = 0.0, hx = 2.0, J0, J1, J2, error;

      using (StreamWriter SW = new StreamWriter("Test_3.txt"))
      {
        SW.WriteLine($"  x             J0(x)                 J1(x)" +
                     $"                 J2(x)            error");
        while (x < 50.5)
        {
          J0 = CBF.BF_J_test3(n0, x);
          J1 = CBF.BF_J_test3(n1, x);
          J2 = CBF.BF_J_test3(n2, x);
          error = J1 - 0.5 * x * (J2 + J0);
          SW.WriteLine($" {x,4:F1}{J0,22:F16}{J1,22:F16}{J2,22:F16}{error,12:E1}");
          x += hx;
        }
      }
    }
  }
}



//using (StreamWriter SW = new StreamWriter("Test_3.txt"))
//{
//  SW.WriteLine($"x             J0(x)                 J1(x)" +
//               $"                 J2(x)            error");
//  while (x< 50.5)
//  {
//    J0 = CBF.BF_J_test3(n0, x);
//    J1 = CBF.BF_J_test3(n1, x);
//    J2 = CBF.BF_J_test3(n2, x);
//    err = J2 + J0 - 2 * J1 / x;
//    SW.WriteLine($" {x,4:F1}{J0,22:F16}{J1,22:F16}{J2,22:F16}{err,12:E1}");
//    x += hx;
//  }
//}
