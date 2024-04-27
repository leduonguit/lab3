namespace Lab1
{
    partial class baiso6
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
            s1 = new TextBox();
            s2 = new TextBox();
            comboBox1 = new ComboBox();
            result = new Button();
            delete = new Button();
            thoat = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 19);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            // 
            // s1
            // 
            s1.Location = new Point(112, 19);
            s1.Name = "s1";
            s1.Size = new Size(125, 27);
            s1.TabIndex = 2;
            // 
            // s2
            // 
            s2.Location = new Point(602, 19);
            s2.Name = "s2";
            s2.Size = new Size(125, 27);
            s2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng Cửu Chương", "Tính toán giá trị" });
            comboBox1.Location = new Point(292, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // result
            // 
            result.Location = new Point(53, 160);
            result.Name = "result";
            result.Size = new Size(139, 44);
            result.TabIndex = 5;
            result.Text = "Tính Các Giá trị";
            result.UseVisualStyleBackColor = true;
            result.Click += result_Click;
            // 
            // delete
            // 
            delete.Location = new Point(292, 160);
            delete.Name = "delete";
            delete.Size = new Size(123, 44);
            delete.TabIndex = 6;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(549, 160);
            thoat.Name = "thoat";
            thoat.Size = new Size(122, 44);
            thoat.TabIndex = 7;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 219);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(627, 234);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 219);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 9;
            label3.Text = "kết quả";
            label3.Click += label3_Click;
            // 
            // baiso6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(thoat);
            Controls.Add(delete);
            Controls.Add(result);
            Controls.Add(comboBox1);
            Controls.Add(s2);
            Controls.Add(s1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "baiso6";
            Text = "bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox s1;
        private TextBox s2;
        private ComboBox comboBox1;
        private Button result;
        private Button delete;
        private Button thoat;
        private TextBox textBox3;
        private Label label3;
    }
}