using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;

            try
            {
                num1 = Int32.Parse(s3.Text.Trim());
                num2 = Int32.Parse(s4.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sum = num1 + num2;
            s5.Text = sum.ToString();
        }

    
        private void s3_TextChanged(object sender, EventArgs e)
        {

        }

        private void s4_TextChanged(object sender, EventArgs e)
        {

        }

        private void s2_TextChanged(object sender, EventArgs e)
        {

        }

        private void s1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
