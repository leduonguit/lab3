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
    public partial class bai5 : Form
    {
        private double ketqua;
        string tenKhachHang;
        string bophim;
        string ghe;
        public bai5()
        {
            InitializeComponent();
            ketqua = 0;
            tenKhachHang = "";
            bophim = "";
            ghe = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 25000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 17500;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 22500;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 11250;
            }
            ghe = A1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ghe = A3.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 100000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 70000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 90000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 45000;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bophim = comboBox1.Text;
        }

        private void A5_Click(object sender, EventArgs e)
        {
            ghe = A5.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 25000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 17500;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 22500;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 11250;
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            ghe = B1.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 25000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 17500;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 22500;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 11250;
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {ghe = B5.Text;

            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 25000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 17500;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 22500;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 11250;
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {ghe= C1.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 25000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 17500;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 22500;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 11250;
            }
        }

        private void C5_Click(object sender, EventArgs e)
        {ghe    = C5.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 25000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 17500;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 22500;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 11250;
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            ghe = A2.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 100000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 70000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 90000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 45000;
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {   ghe=A4.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 100000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 70000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 90000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 45000;
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {ghe=C2.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 100000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 70000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 90000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 45000;
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {ghe =C3.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 100000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 70000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 90000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 45000;
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {ghe=C4.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 100000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 70000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 90000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 45000;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            ghe = B2.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 200000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 140000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 180000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 90000;
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            ghe= B3.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 200000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 140000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 180000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 90000;
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            ghe = B4.Text;
            if (this.comboBox1.Text == "Mai")
            {
                this.ketqua = 200000;
            }
            else if (this.comboBox1.Text == "Gặp lại chị bầu")
            {
                this.ketqua = 140000;
            }
            else if (this.comboBox1.Text == "Tarot")
            {
                this.ketqua = 180000;
            }
            else if (this.comboBox1.Text == "Đào,phở và piano")
            {
                this.ketqua = 90000;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            
           xuatra(sender, e);   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void xuatra(object sender, EventArgs e)
        {
          
            string ketquaString = ketqua.ToString();
          

            string thongTinToanBo ="Tên khách hàng: " +tenKhachHang + "\n" +"vị trí: "+ ghe+"\n" +"bộ phim : "+bophim+"\n" +"giá vé " + ketquaString;
            MessageBox.Show(thongTinToanBo);

        }
        private void bai5_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tenKhachHang = textBox2.Text;
        }
    }
}
