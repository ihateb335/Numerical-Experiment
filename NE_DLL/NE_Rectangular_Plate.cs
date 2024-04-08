using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE_DLL
{
    public class NE_Rectangular_Plate
    {
        readonly double T1, T2, T3, T4, a, b;
        readonly int k1, k2, k3, k4;
        readonly double a1_1, a1_2, bt_3, bt_4;

        public NE_Rectangular_Plate(
            double a, double b, 
            double T1, double T2, double T3, double T4,
            int k1, int k2, int k3, int k4)
        {
            this.T1 = T1;
            this.T2 = T2;
            this.T3 = T3;
            this.T4 = T4;
            this.a = a;
            this.b = b;
            this.k1 = k1;
            this.k2 = k2;
            this.k3 = k3;
            this.k4 = k4;

            a1_1 = Math.PI * k1 / a;
            a1_2 = Math.PI * k2 / a;
            bt_3 = Math.PI * k3 / b;
            bt_4 = Math.PI * k4 / b;
        }

        private double GetT(double exp1, double exp2, double exp3) 
            => Math.Exp(-exp1) * (1.0 - Math.Exp(-2.0 * exp2)) / (1.0 - Math.Exp(-2.0 * exp3)) ;

        public double GetTemperatureAtPoint(double x, double y)
        {
            // формули (20) -(23)
            double
                t1 = GetT(a1_1 * y, a1_1 * (b - y), a1_1 * b ),
                t2 = GetT(a1_2 * (b - y), a1_2 * y, a1_2 * b ),
                t3 = GetT(bt_3 * x, bt_3 * (a - x), bt_3 * a ),
                t4 = GetT(bt_4 * (a - x), bt_4 * x, bt_4 * a );

            // формула (24)
            t1 *= T1 * Math.Sin(a1_1 * x);
            t2 *= T2 * Math.Sin(a1_2 * x);
            t3 *= T3 * Math.Sin(bt_3 * y);
            t4 *= T4 * Math.Sin(bt_4 * y);

            return t1 + t2 + t3 + t4;
        }

    }
}
