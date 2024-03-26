using System;
using System.Threading;
using System.Windows.Forms;

namespace NE_LW_02
{
    public partial class Main_Form_LW_02 : Form
    {
        Thread thread1, thread2;

        public Main_Form_LW_02()
        {
            InitializeComponent();
            thread1 = null;
            thread2 = null;
        }
        
        private void threadAction(object progressBarAsObject)
        {
            var progressBar = progressBarAsObject as ProgressBar;

            progressBar.Value = 0;
            for (int i = 0; i <= progressBar.Maximum; i += progressBar.Step)
            {

                progressBar.Value = i;
                Thread.Sleep(progressBar.Step * 10);
            }
        }

        private void startButton1_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(threadAction); 
            thread1.Start(progressBar1); 
            startButton1.Enabled = false; 
        }

        private void startButton2_Click(object sender, EventArgs e)
        {
            thread2 = new Thread(threadAction);
            thread2.Start(progressBar2);
            startButton2.Enabled = false; 
        }

        private void setStatus(ref Thread thread, int threadNumber, Label label, Button button, ProgressBar progressBar)
        {
            if (thread != null)
            {
                label.Text = $"Статус виконання потоку {threadNumber} = {progressBar.Value}";

                if (!thread.IsAlive)
                {
                    button.Enabled = true;
                    thread = null;
                }
            }
        }

        private void timerl_Tick(object sender, EventArgs e)
        {
            setStatus(ref thread1, 1, statusLabel1, startButton1, progressBar1);

            setStatus(ref thread2, 2, statusLabel2, startButton2, progressBar2);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            IterationLabel.Text = $"Кількість ітерацій = {trackBar1.Value}";
        }

        private void abortThreadOnClosing(ref Thread thread)
        {
            if (thread != null)
            {
                if (thread.IsAlive)
                {
                    thread.Abort();
                    thread = null;
                }
            }
        }
        private void Main_Form_LW_02_FormClosing(object sender, FormClosingEventArgs e)
        {
            abortThreadOnClosing(ref thread1);
            abortThreadOnClosing(ref thread2);
        }
    }
}
