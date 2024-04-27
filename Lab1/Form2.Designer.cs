namespace Lab1
{
    partial class bai1
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
            s1 = new TextBox();
            s3 = new TextBox();
            s4 = new TextBox();
            s5 = new TextBox();
            result = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // s1
            // 
            s1.Location = new Point(0, 0);
            s1.Name = "s1";
            s1.Size = new Size(125, 27);
            s1.TabIndex = 0;
            s1.Text = "Số thứ nhất";
            s1.TextChanged += s1_TextChanged;
            // 
            // s3
            // 
            s3.Location = new Point(267, 0);
            s3.Name = "s3";
            s3.Size = new Size(125, 27);
            s3.TabIndex = 3;
            s3.TextChanged += s3_TextChanged;
            // 
            // s4
            // 
            s4.Location = new Point(267, 76);
            s4.Name = "s4";
            s4.Size = new Size(125, 27);
            s4.TabIndex = 4;
            s4.TextChanged += s4_TextChanged;
            // 
            // s5
            // 
            s5.Location = new Point(267, 158);
            s5.Name = "s5";
            s5.Size = new Size(125, 27);
            s5.TabIndex = 5;
            // 
            // result
            // 
            result.Location = new Point(0, 175);
            result.Name = "result";
            result.Size = new Size(94, 29);
            result.TabIndex = 2;
            result.Text = "kết quả";
            result.UseVisualStyleBackColor = true;
            result.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "Số thứ hai";
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(s5);
            Controls.Add(s4);
            Controls.Add(s3);
            Controls.Add(result);
            Controls.Add(s1);
            Name = "bai1";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox s1;
        private TextBox s3;
        private TextBox s4;
        private TextBox s5;
        private Button result;
        private TextBox textBox1;
    }
}