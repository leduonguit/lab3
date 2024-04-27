namespace Lab1
{
    partial class bai9
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
            Random = new Button();
            Delete = new Button();
            thoat = new Button();
            Add = new Button();
            textBox1 = new TextBox();
            monan = new CheckedListBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 23);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhập món ăn";
            // 
            // Random
            // 
            Random.Location = new Point(2, 180);
            Random.Name = "Random";
            Random.Size = new Size(114, 48);
            Random.TabIndex = 1;
            Random.Text = "Tìm món ăn";
            Random.UseVisualStyleBackColor = true;
            Random.Click += Random_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(256, 180);
            Delete.Name = "Delete";
            Delete.Size = new Size(110, 48);
            Delete.TabIndex = 2;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(520, 180);
            thoat.Name = "thoat";
            thoat.Size = new Size(111, 48);
            thoat.TabIndex = 3;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // Add
            // 
            Add.Location = new Point(406, 27);
            Add.Name = "Add";
            Add.Size = new Size(100, 36);
            Add.TabIndex = 4;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // monan
            // 
            monan.FormattingEnabled = true;
            monan.Location = new Point(542, 12);
            monan.Name = "monan";
            monan.Size = new Size(150, 114);
            monan.TabIndex = 6;
            monan.SelectedIndexChanged += monan_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // bai9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(monan);
            Controls.Add(textBox1);
            Controls.Add(Add);
            Controls.Add(thoat);
            Controls.Add(Delete);
            Controls.Add(Random);
            Controls.Add(label1);
            Name = "bai9";
            Text = "bai9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Random;
        private Button Delete;
        private Button thoat;
        private Button Add;
        private TextBox textBox1;
        private CheckedListBox monan;
        private TextBox textBox2;
    }
}