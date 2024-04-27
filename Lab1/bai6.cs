using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class baiso8 : Form
    {
        public baiso8()
        {
            InitializeComponent();
        }

        private void bai6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            t0.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void view_Click(object sender, EventArgs e)
        {

            string Mang = t0.Text;
            // Kiểm tra tính hợp lệ của Mảng
            if (!KiemTra(Mang))
            {
                MessageBox.Show("Định dạng không hợp lệ!");
                return;
            }
            string[] elements = Mang.Split(',');

            // Lấy họ và tên 
            string hoTen = elements[0];
            t1.Text = hoTen;
            double[] diem = elements.Skip(1).Select(double.Parse).ToArray();
            double diemTB = 0;
            StringBuilder diemText = new StringBuilder();
          


            for (int i = 0; i < diem.Length; i++)
            {
                // Thêm điểm của từng môn vào chuỗi
                diemText.Append("Môn " + (i + 1) + ": " + diem[i] + "       ");
                if ((i + 1) % 4 == 0)
                    diemText.AppendLine();

                // Tính tổng điểm
                diemTB += diem[i];
            }

            textBox1.Text = diemText.ToString();
            // Tính điểm trung bình
            diemTB = diem.Sum() / diem.Length;

            // Làm tròn điểm trung bình với hai chữ số thập phân
            string roundedDiemTB = diemTB.ToString("N2");
            medium.Text = roundedDiemTB;
            double diemCaoNhat = diem.Max();
            double diemThapNhat = diem.Min();

            int indexDiemCaoNhat = Array.IndexOf(diem, diemCaoNhat) + 1;
            int indexDiemThapNhat = Array.IndexOf(diem, diemThapNhat) + 1;

            t3.Text = indexDiemCaoNhat.ToString();
            t6.Text = indexDiemThapNhat.ToString();

            // Tìm số môn đậu và số môn không đậu
            int soMonDau = diem.Count(d => d >= 5);
            int soMonRot = diem.Count(d => d < 5);
            t4.Text = soMonDau.ToString();
            t7.Text = soMonRot.ToString();
            // Xếp loại sinh viên
            if (diemTB >= 8 && diem.All(d => d >= 6.5))
            {
                t5.Text = "Giỏi";
            }
            else if (diemTB >= 6.5 && diem.All(d => d >= 5))
            {
                t5.Text = "Khá";
            }
            else if (diemTB >= 5 && diem.All(d => d >= 3.5))
            {
                t5.Text = "Trung Bình";
            }
            else if (diemTB >= 3.5 && diem.All(d => d >= 2))
            {
                t5.Text = "Yếu";
            }
            else
            {
                t5.Text = "Kém";
            }
        }


        private void medium_TextChanged(object sender, EventArgs e)
        {

        }

        private void t3_TextChanged(object sender, EventArgs e)
        {

        }

        private void t0_TextChanged(object sender, EventArgs e)
        {

        }

        private void t6_TextChanged(object sender, EventArgs e)
        {

        }
        private bool KiemTra(string Mang)
        {
            // Kiểm tra chuỗi
            string[] elements = Mang.Split(',');

            if (elements.Length < 2)
            {
                return false;
            }

            // Kiểm tra số hợp lệ
            for (int i = 1; i < elements.Length; i++)
            {
                if (!double.TryParse(elements[i], out _))
                {
                    return false;
                }
            }

            return true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
