using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NE_LW_03
{
    public partial class Main_Form_LW_03 : Form
    {
        public static double a, b;
        public static int k = -1, n;
        public static string Result = "";
        private List<Form_Stream> ListOfStreams;
        public Main_Form_LW_03()
        {
            InitializeComponent();
            ListOfStreams = new List<Form_Stream>();
        }

        void CalculateButton_Click(object sender, EventArgs e)
        {
            k++; n = (int)nNUD.Value;
            a = (double)alphaNUD.Value; b = (double)betaNUD.Value;
            ListOfStreams.Add(new Form_Stream());
            ListOfStreams[k].StartPosition = FormStartPosition.Manual;
            ListOfStreams[k].Location = new Point(Location.X + 50 + k * 30, Location.Y + 275 + k * 30);
            ListOfStreams[k].Show();
            ListOfStreams[k].StartStream();
        }

        void ResultButton_Click(object sender, EventArgs e)
        {
            if (k == -1) resultTextBox.Text = "Oбчислень ще не було!";
            else resultTextBox.Text = Result;
        }

        void Main_Form_LW_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form_Stream form_stream in ListOfStreams)
            {
                if (form_stream.stream == null) { form_stream.Dispose(); continue; }
                if (form_stream.stream.IsAlive) form_stream.stream.Abort();
                form_stream.Dispose();
            }
        }

    }
}
