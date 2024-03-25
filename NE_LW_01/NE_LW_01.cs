using System.IO;
using CBF = NE_DLL.NE_Bessel_Functions;

namespace NE_LW_01
{
    internal class NE_LW_01
    {
        static void Test1_3(string fileName, Func<int, double, double, double> function, double eps = 1.0E-17 )
        {
            const int
                n0 = 0,
                n1 = 1,
                n2 = 2;

            double
                x = 0.0,
                hx = 2.0,
                J0, J1, J2, error;


            using (StreamWriter SW = new StreamWriter(fileName))
            {
                SW.WriteLine($"x             J0(x)                 J1(x)" +
                     $"                 J2(x)            error");
                while (x < 50.5)
                {
                    J0 = function(n0, x, eps);
                    J1 = function(n1, x, eps);
                    J2 = function(n2, x, eps);

                    error = J1 - 0.5 * x * (J2 + J0);

                    SW.WriteLine($" {x,4:F1}{J0,22:F16}{J1,22:F16}{J2,22:F16}{error,12:E1}");
                    x += hx;
                }
            }
        }



        static void Main(string[] args)
        {
            //Test1_3("Test_1.txt", CBF.BF_J_test1);
            //Test1_3("Test_2.txt", CBF.BF_J_test2);
            //Test1_3("Test_3.txt", CBF.BF_J_test3);

            //Test_4.Run("Test_4.txt");
            Test_5.Run("Test_5.txt");
        }
    }
}
