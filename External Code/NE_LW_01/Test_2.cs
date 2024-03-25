using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CBF = NE_DLL.NE_Bessel_Functions;

namespace NE_LW_01_Test_2
{
  class Test_2
  {
    static void Main(string[] args)
    {
      const int n0 = 0, n1 = 1, n2 = 2;
      double x = 0.0, hx = 2.0, J0, J1, J2, error;

      using (StreamWriter SW = new StreamWriter("Test_2.txt"))
      {
        SW.WriteLine($"x             J0(x)                 J1(x)" +
                     $"                 J2(x)            error");
        while (x < 50.5)
        {
          J0 = CBF.BF_J_test2(n0, x);
          J1 = CBF.BF_J_test2(n1, x);
          J2 = CBF.BF_J_test2(n2, x);
          error = J1 - 0.5 * x * (J2 + J0);
          SW.WriteLine($" {x,4:F1}{J0,22:F16}{J1,22:F16}{J2,22:F16}{error,12:E1}");
          x += hx;
        }
      }
    }
  }
}
