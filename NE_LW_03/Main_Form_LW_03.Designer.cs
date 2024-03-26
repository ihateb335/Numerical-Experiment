namespace NE_LW_03
{
    partial class Main_Form_LW_03
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            CalculateButton = new Button();
            label3 = new Label();
            nNUD = new NumericUpDown();
            label2 = new Label();
            betaNUD = new NumericUpDown();
            label1 = new Label();
            alphaNUD = new NumericUpDown();
            groupBox2 = new GroupBox();
            resultTextBox = new TextBox();
            groupBox3 = new GroupBox();
            ShowResultsButton = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)betaNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alphaNUD).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CalculateButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nNUD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(betaNUD);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(alphaNUD);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(933, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметри обчислень";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(36, 51);
            CalculateButton.Margin = new Padding(4, 3, 4, 3);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(88, 27);
            CalculateButton.TabIndex = 6;
            CalculateButton.Text = "Обчислити";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(611, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 5;
            label3.Text = "n =";
            // 
            // nNUD
            // 
            nNUD.Location = new Point(644, 54);
            nNUD.Margin = new Padding(4, 3, 4, 3);
            nNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nNUD.Name = "nNUD";
            nNUD.Size = new Size(140, 23);
            nNUD.TabIndex = 4;
            nNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "beta =";
            // 
            // betaNUD
            // 
            betaNUD.DecimalPlaces = 2;
            betaNUD.Location = new Point(427, 54);
            betaNUD.Margin = new Padding(4, 3, 4, 3);
            betaNUD.Name = "betaNUD";
            betaNUD.Size = new Size(140, 23);
            betaNUD.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "alpha =";
            // 
            // alphaNUD
            // 
            alphaNUD.DecimalPlaces = 2;
            alphaNUD.Location = new Point(214, 52);
            alphaNUD.Margin = new Padding(4, 3, 4, 3);
            alphaNUD.Name = "alphaNUD";
            alphaNUD.Size = new Size(140, 23);
            alphaNUD.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultTextBox);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 115);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(933, 404);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результати";
            // 
            // resultTextBox
            // 
            resultTextBox.Dock = DockStyle.Top;
            resultTextBox.Location = new Point(4, 126);
            resultTextBox.Margin = new Padding(4, 3, 4, 3);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ScrollBars = ScrollBars.Vertical;
            resultTextBox.Size = new Size(925, 230);
            resultTextBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ShowResultsButton);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(4, 19);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(925, 107);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // ShowResultsButton
            // 
            ShowResultsButton.Location = new Point(769, 50);
            ShowResultsButton.Margin = new Padding(4, 3, 4, 3);
            ShowResultsButton.Name = "ShowResultsButton";
            ShowResultsButton.Size = new Size(88, 27);
            ShowResultsButton.TabIndex = 6;
            ShowResultsButton.Text = "Результати";
            ShowResultsButton.UseVisualStyleBackColor = true;
            ShowResultsButton.Click += ResultButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(454, 57);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 13);
            label9.TabIndex = 5;
            label9.Text = "Час виконання";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(322, 57);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 13);
            label8.TabIndex = 4;
            label8.Text = "Інтеграл";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(240, 57);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(14, 13);
            label7.TabIndex = 3;
            label7.Text = "n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(131, 55);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 13);
            label6.TabIndex = 2;
            label6.Text = "beta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(65, 55);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 13);
            label5.TabIndex = 1;
            label5.Text = "alpha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(10, 55);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(14, 13);
            label4.TabIndex = 0;
            label4.Text = "k";
            // 
            // Main_Form_LW_03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main_Form_LW_03";
            Text = "Чисельний Експеримент. Лабораторна робота 03.";
            FormClosing += Main_Form_LW_3_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)betaNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)alphaNUD).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown betaNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown alphaNUD;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ShowResultsButton;
    }
}
