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
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }

        private void bai7_Load(object sender, EventArgs e)
        {

        }

        private void s2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void s3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (input.Length == 8 && int.TryParse(input, out int ngayThangNam))
            {
                int ngay = ngayThangNam / 1000000;
                int thang = (ngayThangNam / 10000) % 100;
                int nam = ngayThangNam % 10000;

                try
                {
                    DateTime ngaySinh = new DateTime(nam, thang, ngay);
                    string cungHoangDao = XacDinhCungHoangDao(ngaySinh);
                    textBox2.Text = cungHoangDao;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                }

            }
            else
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
            }
        }
        private string XacDinhCungHoangDao(DateTime ngaySinh)
        {
            int ngay = ngaySinh.Day;
            int thang = ngaySinh.Month;

            if ((thang == 3 && ngay >= 21) || (thang == 4 && ngay <= 20))
            {
                return "Bạch Dương";
            }
            else if ((thang == 4 && ngay >= 21) || (thang == 5 && ngay <= 21))
            {
                return "Kim Ngưu";
            }
            else if ((thang == 5 && ngay >= 22) || (thang == 6 && ngay <= 21))
            {
                return "Song Tử";
            }
            else if ((thang == 6 && ngay >= 22 || thang == 7 && ngay <= 22))
            {

                return "Cự Giải";
            }
            else if (thang == 7 && ngay >= 23 || thang == 8 && ngay <= 22)
            {
                return "Sư Tử";
            }
            else if (thang == 8 && ngay >= 23 || thang == 9 && ngay <= 23)
            {
                return "Xử Nữ";
            }
            else if (thang == 9 && ngay >= 24 || thang == 10 && ngay <= 23)
            {
                return "Thiên Bình";
            }
            else if (thang == 10 && ngay >= 24 || thang == 11 && ngay <= 22)
            {
                return "Thần Nông";
            }
            else if (thang == 11 && ngay >= 23 || thang == 12 && ngay <= 21)
            {
                return "Nhân Mã";
            }
            else if (thang == 12 && ngay >= 22 || thang == 1 && ngay <= 20)
            {
                return "Ma Kết";
            }
            else if (thang == 1 && ngay >= 21 || thang == 2 && ngay <= 19)
            {
                return "Bảo Bình";
            }
            else if (thang == 2 && ngay >= 20 || thang == 3 && ngay <= 20)
            {
                return "Song Ngư";
            }
            return "";
        }


    }
}
