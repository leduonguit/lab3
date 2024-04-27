namespace Lab1
{
    partial class bai7
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            s2 = new Button();
            s3 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 35);
            label1.Name = "label1";
            label1.Size = new Size(390, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào ngày tháng năm sinh(dd/mm/yy)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Cung hoàng đạo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(438, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // s2
            // 
            s2.Location = new Point(624, 124);
            s2.Name = "s2";
            s2.Size = new Size(94, 29);
            s2.TabIndex = 6;
            s2.Text = "xóa";
            s2.UseVisualStyleBackColor = true;
            s2.Click += s2_Click;
            // 
            // s3
            // 
            s3.Location = new Point(624, 210);
            s3.Name = "s3";
            s3.Size = new Size(94, 29);
            s3.TabIndex = 7;
            s3.Text = "thoát";
            s3.UseVisualStyleBackColor = true;
            s3.Click += s3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(624, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "xem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(438, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(s3);
            Controls.Add(s2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bai7";
            Text = "bai7";
            Load += bai7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button s2;
        private Button s3;
        private Button button1;
        private TextBox textBox2;
    }
}