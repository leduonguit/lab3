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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void s1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(s4.Text);
            switch (a)
            {
                case 0:

                    {
                        this.s5.Text = "số không";
                    }

                    break;

                case 1:
                    {
                        this.s5.Text = "Số một";

                    }
                    break;
                case 2:
                    {
                        this.s5.Text = "hai";

                    }
                    break;
                case 3:
                    {
                        this.s5.Text = "ba";

                    }
                    break;
                case 4:
                    {
                        this.s5.Text = "bốn";

                    }
                    break;
                case 5:
                    {
                        this.s5.Text = "năm";

                    }
                    break;
                case 6:
                    {
                        this.s5.Text = "sáu";

                    }
                    break;
                case 7:
                    {
                        this.s5.Text = "bảy";

                    }
                    break;
                case 8:
                    {
                        this.s5.Text = "tám";

                    }
                    break;

                case 9:
                    {
                        this.s5.Text = "chín";

                    }
                    break;
            }




        }

        private void s4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void s2_Click(object sender, EventArgs e)
        {
            s5.Text = "";
        }
    }
}
