using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NE_DLL;
using CGQ = NE_DLL.MAC_Gauss_Quadrature;
using CBF = NE_DLL.NE_Bessel_Functions;

namespace NE_LW_03
{
    public partial class Form_Stream : Form
    {

        double Alpha, Beta, Integral; 
        int K, n;
        Stopwatch clock;
        CGQ gauss;
        public Thread stream;

        readonly static double Error = 1.0E-7;
        public Form_Stream()
        {
            InitializeComponent();
            K = Main_Form_LW_03.k;
            n = Main_Form_LW_03.n;
            Alpha = Main_Form_LW_03.a;
            Beta = Main_Form_LW_03.b;

            Text = $"   {K}-й потік ";
            groupBox1.Text = $"    alpha = {Alpha, 4:F2}    beta = {Beta, 4:F2}     n = {n} ";
            timer1.Enabled = true;
        }

        private double AB_11_4_36(double t) => CBF.Jn(n, Alpha * t, Error) * Math.Cos(Beta * t) / t;

        public void StartStream()
        {
            stream = new Thread(() =>
            {
                clock = new Stopwatch();
                clock.Start();

                gauss = new CGQ(32);
                Integral = gauss.Improper(0.0, AB_11_4_36, Error, out double B);

                clock.Stop();

            });

            stream.Start();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            decimal time = clock.ElapsedMilliseconds / 1000;
            int status = (int)gauss.status; if (status > 100) status = 100;
            if (!stream.IsAlive)
            {
                Main_Form_LW_03.Result += $"{K,3:F0}\t{Alpha,8:F2}\t{Beta,8:F2}\t\t{n,5:F0}\t{Integral,21:F14}\t\t{time,11:F1} сек \r\n";
                integralValueLabel.Text = string.Format("Інтеграл = {0:F14}", Integral);
                stream = null; timer1.Enabled = false;
            }
            progressBar1.Value = status;
            completedLabel.Text = $" Виконано {status} %";
            durationLabel.Text = $" Тривалість обчислень {time} сек";
            Refresh();
        }
    }
}
