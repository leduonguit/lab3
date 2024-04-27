namespace Lab1
{


    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 form2 = new bai1();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai4 form5 = new bai4();
            form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bai5 form6 = new bai5();
            form6.ShowDialog();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void b3_Click(object sender, EventArgs e)
        {
            bai3 form4 = new bai3();
            form4.ShowDialog();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            baiso6 bai6 = new baiso6();
            bai6.ShowDialog();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            bai7 bai7 = new bai7();
            bai7.ShowDialog();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            baiso8 bai8 = new baiso8();
            bai8.ShowDialog();

        }

        private void b9_Click(object sender, EventArgs e)
        {
            bai9 bai9 = new bai9();
            bai9.ShowDialog();
        }
    }
}
