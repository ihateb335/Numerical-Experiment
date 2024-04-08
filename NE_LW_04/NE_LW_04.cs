using System.IO;
using RP = NE_DLL.NE_Rectangular_Plate;

namespace NE_LW_04
{
    internal class NE_LW_04
    {
        static void Main(string[] args)
        {
            //Test data
            WriteData(
                30.0, 20.0, -15.0, 15.0, //T
                2.0, 1.0, // a, b
                5, 3, 1, 2, // k 1 - 4
                1.0, 0.2, 1.5, 0.75, //Points
                "Nodes_LW_04.txt", "Map_LW_04.txt"
            );
            //Variant 5
            WriteData(
                20.0, 5.0, 25.0, -10.0, //T
                2.0, 1.0, // a, b
                2, 5, 6, 1, // k 1 - 4
                .3, .55, 1.25, 0.65, //Points
                "Nodes_LW_04_Variant_05.txt", "Map_LW_04_Variant_05.txt", 200
            );
        }

        static private void WriteData(
            double T1, double T2, double T3, double T4, 
            double a, double b,
            int k1, int k2, int k3, int k4,
            double xc1, double yc1, double xc2, double yc2,
            string nodeFileName, string mapFileName, int m = 400
        )
        {
           
            RP plate = new RP(a, b, T1, T2, T3, T4, k1, k2, k3, k4);

            StreamWriter writer = new StreamWriter(nodeFileName);
            double t1 = plate.GetTemperatureAtPoint(xc1, yc1), t2 = plate.GetTemperatureAtPoint(xc2, yc2);
            writer.WriteLine($" t1 = {t1,18:F8}     t2 = {t2,18:F8}");
            writer.Close();

            writer = new StreamWriter(mapFileName);
            int i, j, M = (int)(a * m), N = (int)(b * m);
            double h = 1.0 / m, x = 0.0, y = 0.0;
            for (j = 0; j <= N; j++)
            {

                y = h * j;
                for (i = 0; i <= M; i++)
                {


                    x = h * i; t1 = plate.GetTemperatureAtPoint(x, y);
                    writer.WriteLine($" {x,10:F6}   {y,10:F6}  {t1,12:F8}".Replace(',', '.'));
                }
            }
            writer.Close();
        }

    }
}
