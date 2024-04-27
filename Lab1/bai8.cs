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
    public partial class baiso6 : Form
    {
        public baiso6()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            int num1, num2;


            try
            {
                num1 = Int32.Parse(s1.Text.Trim());
                num2 = Int32.Parse(s2.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.comboBox1.Text == "Bảng Cửu Chương")
            {
                string ketqua = "";
                for (int i = 1; i <= 10; i++)
                {
                    int multiplicationResult = (num2 - num1) * i;
                    ketqua += $"{num2 - num1} x {i} = {multiplicationResult}\r\n";
                }
                textBox3.Text = ketqua;

            }
            else if (this.comboBox1.Text == "Tính toán giá trị")
            {
                
                double tong=1;

                for (int i = 1; i <= num2-num1; i++)
                {
                    tong =tong * i;
                }
                int sum = 0;
                for (int i = 1; i <= num2; i++)
                {
                    int powerResult = (int)Math.Pow(num1, i);
                    sum += powerResult;
                }
                textBox3.Text = "(B-A)! = " + tong + "\r\n" + "Tổng S = A^1 + A^2 + A^3 + ... + A^B = "  + sum;
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
