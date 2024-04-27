namespace Lab1
{
    partial class Form3
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
            textBox1 = new TextBox();
            s3 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            s1 = new TextBox();
            s2 = new TextBox();
            max2 = new TextBox();
            result = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Enabled = false;
            textBox1.Location = new Point(64, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Số thứ nhất";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // s3
            // 
            s3.Location = new Point(568, 164);
            s3.Name = "s3";
            s3.Size = new Size(125, 27);
            s3.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(568, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Số thứ 3";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(293, 35);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "Số thứ 2";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // s1
            // 
            s1.Location = new Point(64, 164);
            s1.Name = "s1";
            s1.Size = new Size(125, 27);
            s1.TabIndex = 5;
            // 
            // s2
            // 
            s2.Location = new Point(282, 164);
            s2.Name = "s2";
            s2.Size = new Size(125, 27);
            s2.TabIndex = 6;
            // 
            // max2
            // 
            max2.Location = new Point(293, 271);
            max2.Name = "max2";
            max2.Size = new Size(125, 27);
            max2.TabIndex = 7;
            // 
            // result
            // 
            result.Location = new Point(48, 269);
            result.Name = "result";
            result.Size = new Size(94, 29);
            result.TabIndex = 8;
            result.Text = "kết quả";
            result.UseVisualStyleBackColor = true;
            result.Click += result_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(max2);
            Controls.Add(s2);
            Controls.Add(s1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(s3);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox s3;
        private TextBox textBox3;
        private TextBox textBox4;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox s1;
        private TextBox s2;
        private TextBox max2;
        private Button result;
    }
}