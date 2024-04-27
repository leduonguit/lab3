namespace Lab1
{
    partial class Main
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
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Location = new Point(21, 67);
            b1.Name = "b1";
            b1.Size = new Size(125, 93);
            b1.TabIndex = 0;
            b1.Text = "bài 1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(185, 67);
            b2.Name = "b2";
            b2.Size = new Size(125, 93);
            b2.TabIndex = 1;
            b2.Text = "bài 2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(348, 67);
            b3.Name = "b3";
            b3.Size = new Size(125, 93);
            b3.TabIndex = 2;
            b3.Text = "bài 3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.Location = new Point(493, 67);
            b4.Name = "b4";
            b4.Size = new Size(125, 93);
            b4.TabIndex = 3;
            b4.Text = "bài 3.1";
            b4.UseVisualStyleBackColor = true;
            b4.Click += button4_Click;
            // 
            // b5
            // 
            b5.Location = new Point(21, 233);
            b5.Name = "b5";
            b5.Size = new Size(125, 85);
            b5.TabIndex = 4;
            b5.Text = "bài 5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += button5_Click;
            // 
            // b6
            // 
            b6.Location = new Point(167, 233);
            b6.Name = "b6";
            b6.Size = new Size(125, 85);
            b6.TabIndex = 5;
            b6.Text = "bài 6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b7
            // 
            b7.Location = new Point(343, 233);
            b7.Name = "b7";
            b7.Size = new Size(130, 88);
            b7.TabIndex = 6;
            b7.Text = "bài 7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.Location = new Point(493, 233);
            b8.Name = "b8";
            b8.Size = new Size(125, 88);
            b8.TabIndex = 7;
            b8.Text = "bài 8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Location = new Point(244, 166);
            b9.Name = "b9";
            b9.Size = new Size(191, 63);
            b9.TabIndex = 8;
            b9.Text = "bài 9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Name = "Main";
            Text = "Main";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
    }
}
