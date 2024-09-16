namespace Tung_Buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            Singvien sv = new Singvien();
            sv.setDiaChi(txt_DC.Text);
            sv.setMSSV(txt_MaSV.Text); 
            sv.setGioiTinh(txt_GT.Text);
            sv.setHoTen(txt_HT.Text);
            sv.setngaysinh
        }
    }
}
