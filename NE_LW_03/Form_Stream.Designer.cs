namespace NE_LW_03
{
    partial class Form_Stream
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            progressBar1 = new ProgressBar();
            durationLabel = new Label();
            completedLabel = new Label();
            integralValueLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1065, 51);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "alpha = 0    beta = 0    n = 1";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(4, 25);
            progressBar1.Margin = new Padding(4, 3, 4, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1057, 23);
            progressBar1.TabIndex = 0;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            durationLabel.ForeColor = Color.Blue;
            durationLabel.Location = new Point(15, 85);
            durationLabel.Margin = new Padding(4, 0, 4, 0);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(154, 13);
            durationLabel.TabIndex = 1;
            durationLabel.Text = "Тривалість обчислень = ";
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            completedLabel.ForeColor = Color.RosyBrown;
            completedLabel.Location = new Point(337, 85);
            completedLabel.Margin = new Padding(4, 0, 4, 0);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new Size(77, 13);
            completedLabel.TabIndex = 2;
            completedLabel.Text = "Виконано %";
            // 
            // integralValueLabel
            // 
            integralValueLabel.AutoSize = true;
            integralValueLabel.ForeColor = Color.Red;
            integralValueLabel.Location = new Point(610, 85);
            integralValueLabel.Margin = new Padding(4, 0, 4, 0);
            integralValueLabel.Name = "integralValueLabel";
            integralValueLabel.Size = new Size(69, 13);
            integralValueLabel.TabIndex = 3;
            integralValueLabel.Text = "Інтеграл =";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form_Stream
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 132);
            Controls.Add(integralValueLabel);
            Controls.Add(completedLabel);
            Controls.Add(durationLabel);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_Stream";
            Text = "-й потік";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label completedLabel;
        private System.Windows.Forms.Label integralValueLabel;
        private System.Windows.Forms.Timer timer1;
    }
}