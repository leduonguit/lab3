namespace Lab1
{
    partial class baiso8
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
            label3 = new Label();
            max = new Label();
            label5 = new Label();
            dau = new Label();
            label7 = new Label();
            label8 = new Label();
            t1 = new TextBox();
            medium = new TextBox();
            t5 = new TextBox();
            t3 = new TextBox();
            t6 = new TextBox();
            t4 = new TextBox();
            t7 = new TextBox();
            label9 = new Label();
            view = new Button();
            thoat = new Button();
            Delete = new Button();
            t0 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin sinh viên(Tên,điểm)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(0, 56);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(284, 246);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 2;
            label3.Text = "MônThấp nhất";
            // 
            // max
            // 
            max.AutoSize = true;
            max.Font = new Font("Segoe UI", 12F);
            max.Location = new Point(0, 246);
            max.Name = "max";
            max.Size = new Size(136, 28);
            max.TabIndex = 3;
            max.Text = "Môn Cao nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(284, 176);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 4;
            label5.Text = "Xếp loại";
            // 
            // dau
            // 
            dau.AutoSize = true;
            dau.Font = new Font("Segoe UI", 12F);
            dau.Location = new Point(0, 321);
            dau.Name = "dau";
            dau.Size = new Size(115, 28);
            dau.TabIndex = 5;
            dau.Text = "số môn đậu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(272, 321);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 6;
            label7.Text = "Số môn rớt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(0, 176);
            label8.Name = "label8";
            label8.Size = new Size(84, 28);
            label8.TabIndex = 7;
            label8.Text = "Điểm TB";
            // 
            // t1
            // 
            t1.Location = new Point(120, 60);
            t1.Multiline = true;
            t1.Name = "t1";
            t1.Size = new Size(340, 34);
            t1.TabIndex = 8;
            // 
            // medium
            // 
            medium.Location = new Point(130, 177);
            medium.Name = "medium";
            medium.Size = new Size(125, 27);
            medium.TabIndex = 9;
            medium.TextChanged += medium_TextChanged;
            // 
            // t5
            // 
            t5.Location = new Point(430, 176);
            t5.Name = "t5";
            t5.Size = new Size(125, 27);
            t5.TabIndex = 10;
            // 
            // t3
            // 
            t3.Location = new Point(130, 247);
            t3.Name = "t3";
            t3.Size = new Size(125, 27);
            t3.TabIndex = 11;
            t3.TextChanged += t3_TextChanged;
            // 
            // t6
            // 
            t6.Location = new Point(430, 246);
            t6.Name = "t6";
            t6.Size = new Size(125, 27);
            t6.TabIndex = 12;
            t6.TextChanged += t6_TextChanged;
            // 
            // t4
            // 
            t4.Location = new Point(130, 325);
            t4.Name = "t4";
            t4.Size = new Size(125, 27);
            t4.TabIndex = 13;
            // 
            // t7
            // 
            t7.Location = new Point(430, 325);
            t7.Name = "t7";
            t7.Size = new Size(125, 27);
            t7.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(553, 64);
            label9.Name = "label9";
            label9.Size = new Size(68, 31);
            label9.TabIndex = 15;
            label9.Text = "Điểm";
            // 
            // view
            // 
            view.Location = new Point(857, 69);
            view.Name = "view";
            view.Size = new Size(108, 29);
            view.TabIndex = 17;
            view.Text = "Xem chi tiết";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(857, 250);
            thoat.Name = "thoat";
            thoat.Size = new Size(108, 29);
            thoat.TabIndex = 18;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(857, 159);
            Delete.Name = "Delete";
            Delete.Size = new Size(108, 29);
            Delete.TabIndex = 19;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // t0
            // 
            t0.Location = new Point(413, 13);
            t0.Name = "t0";
            t0.Size = new Size(416, 27);
            t0.TabIndex = 21;
            t0.TextChanged += t0_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(627, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 280);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // baiso8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 450);
            Controls.Add(textBox1);
            Controls.Add(t0);
            Controls.Add(Delete);
            Controls.Add(thoat);
            Controls.Add(view);
            Controls.Add(label9);
            Controls.Add(t7);
            Controls.Add(t4);
            Controls.Add(t6);
            Controls.Add(t3);
            Controls.Add(t5);
            Controls.Add(medium);
            Controls.Add(t1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dau);
            Controls.Add(label5);
            Controls.Add(max);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "baiso8";
            Text = "bai6";
            Load += bai6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label max;
        private Label label5;
        private Label dau;
        private Label label7;
        private Label label8;
        private TextBox t1;
        private TextBox medium;
        private TextBox t5;
        private TextBox t3;
        private TextBox t6;
        private TextBox t4;
        private TextBox t7;
        private Label label9;
        private Button view;
        private Button thoat;
        private Button Delete;
        private TextBox t0;
        private TextBox textBox1;
    }
}