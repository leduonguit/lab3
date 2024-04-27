namespace Lab1
{
    partial class bai3
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            s5 = new TextBox();
            s1 = new Button();
            s2 = new Button();
            s3 = new Button();
            s4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Nhập vào một số nguyên từ 0 tới 9\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Kết quả";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // s5
            // 
            s5.Location = new Point(0, 198);
            s5.Name = "s5";
            s5.Size = new Size(149, 27);
            s5.TabIndex = 3;
            s5.TextChanged += textBox4_TextChanged;
            // 
            // s1
            // 
            s1.Location = new Point(570, 0);
            s1.Name = "s1";
            s1.Size = new Size(94, 29);
            s1.TabIndex = 4;
            s1.Text = "đọc";
            s1.UseVisualStyleBackColor = true;
            s1.Click += s1_Click;
            // 
            // s2
            // 
            s2.Location = new Point(570, 92);
            s2.Name = "s2";
            s2.Size = new Size(94, 29);
            s2.TabIndex = 5;
            s2.Text = "xóa";
            s2.UseVisualStyleBackColor = true;
            s2.Click += s2_Click;
            // 
            // s3
            // 
            s3.Location = new Point(570, 182);
            s3.Name = "s3";
            s3.Size = new Size(94, 29);
            s3.TabIndex = 6;
            s3.Text = "thoát";
            s3.UseVisualStyleBackColor = true;
            s3.Click += button3_Click;
            // 
            // s4
            // 
            s4.Location = new Point(326, 0);
            s4.Name = "s4";
            s4.Size = new Size(125, 27);
            s4.TabIndex = 7;
            s4.TextChanged += s4_TextChanged;
            // 
            // bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(s4);
            Controls.Add(s3);
            Controls.Add(s2);
            Controls.Add(s1);
            Controls.Add(s5);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "bai3";
            Text = "bài 3";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox s5;
        private Button s1;
        private Button s2;
        private Button s3;
        private TextBox s4;
    }
}