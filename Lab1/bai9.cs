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
    public partial class bai9 : Form
    {
        public bai9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string newText = textBox1.Text;
            monan.Items.Add(newText);
        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomIndex = random.Next(monan.Items.Count);
            string randomItem = monan.Items[randomIndex].ToString();
            textBox2.Text = randomItem;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
