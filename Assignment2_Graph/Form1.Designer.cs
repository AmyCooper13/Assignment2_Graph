namespace Assignment2_Graph
{
    partial class Form1
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtHotPink = new TextBox();
            txtLightBlue = new TextBox();
            txtPurple = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 327);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 50);
            label1.Name = "label1";
            label1.Size = new Size(280, 20);
            label1.TabIndex = 1;
            label1.Text = "Please input values to build the pie chart:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 110);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Hot Pink:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 172);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Light Blue:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 231);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Purple:";
            // 
            // txtHotPink
            // 
            txtHotPink.Location = new Point(454, 107);
            txtHotPink.Name = "txtHotPink";
            txtHotPink.Size = new Size(125, 27);
            txtHotPink.TabIndex = 5;
            // 
            // txtLightBlue
            // 
            txtLightBlue.Location = new Point(454, 165);
            txtLightBlue.Name = "txtLightBlue";
            txtLightBlue.Size = new Size(125, 27);
            txtLightBlue.TabIndex = 6;
            // 
            // txtPurple
            // 
            txtPurple.Location = new Point(454, 228);
            txtPurple.Name = "txtPurple";
            txtPurple.Size = new Size(125, 27);
            txtPurple.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPurple);
            Controls.Add(txtLightBlue);
            Controls.Add(txtHotPink);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtHotPink;
        private TextBox txtLightBlue;
        private TextBox txtPurple;
    }
}
