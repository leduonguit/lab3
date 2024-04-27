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
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void bai4_Load(object sender, EventArgs e)
        {

        }

        private void s4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void s5_TextChanged(object sender, EventArgs e)
        {

        }
        private void s3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void s1_Click(object sender, EventArgs e)
        {
            long a = long.Parse(s4.Text);
            string[] numberNames = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };

            if (a < 0 || a > 999999999)
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 999999999");
                return;
            }

            string result = "";
            if (a == 0)
            {
                result = numberNames[0];
            }
            else
            {
                int[] groups = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    groups[i] = (int)(a % 1000);
                    a /= 1000;
                }

                for (int i = 2; i >= 0; i--)
                {
                    if (groups[i] != 0)
                    {
                        if (result != "")
                        {
                            result += " ";
                        }
                        result += ReadThreeDigitNumber(groups[i]) + " " + GetGroupUnitName(i);
                    }
                }
            }

            this.s5.Text = result;
        }

        private string ReadThreeDigitNumber(int number)
        {
            string[] numberNames = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };

            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int ones = number % 10;

            string result = "";
            if (hundreds > 0)
            {
                result += numberNames[hundreds] + " trăm";
            }

            if (tens > 0)
            {
                if (result != "")
                {
                    result += " ";
                }

                if (tens == 1)
                {
                    result += numberNames[tens * 10 + ones];
                }
                else
                {
                    result += numberNames[tens + 18];
                    if (ones > 0)
                    {
                        result += " " + numberNames[ones];
                    }
                }
            }
            else if (ones > 0)
            {
                if (result != "")
                {
                    result += " lẻ ";
                }
                result += numberNames[ones];
            }

            return result;
        }

        private string GetGroupUnitName(int groupIndex)
        {
            string[] unitNames = { "", "nghìn", "triệu", "tỷ" };
            return unitNames[groupIndex];
        }

        private void s2_Click(object sender, EventArgs e)
        {
            s5.Text = "";
        }
    }
}