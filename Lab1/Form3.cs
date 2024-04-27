using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            int a = int.Parse(s1.Text);
            int b = int.Parse(s2.Text);
            int c = int.Parse(s3.Text);

            // Tìm số lớn nhất
            int max = Math.Max(Math.Max(a, b), c);

            // Hiển thị kết quả
            max2.Text = max.ToString();
        }
    }
}
