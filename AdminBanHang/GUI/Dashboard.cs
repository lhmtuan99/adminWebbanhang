using System;
using System.Windows.Forms;

namespace AdminBanHang.GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void addForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }
        private void btnQLSP_Click(object sender, EventArgs e)
        {
            QuanlyProduct quanlyProduct = new QuanlyProduct();
            quanlyProduct.Show();
        }

        private void btnQLCB_Click(object sender, EventArgs e)
        {
            QuanlyCombo quanlyCombo = new QuanlyCombo();
            quanlyCombo.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            QuanLyKhachhang quanLyKhachhang = new QuanLyKhachhang();
            quanLyKhachhang.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanvien quanLyNhanvien = new QuanLyNhanvien();
            quanLyNhanvien.Show();
        }

        private void btnQLHĐ_Click(object sender, EventArgs e)
        {
            QuanlyHoadon quanlyHoadon = new QuanlyHoadon();
            quanlyHoadon.Show();
        }

        private void btnNewDH_Click(object sender, EventArgs e)
        {
            LapDonHang lapDonHang = new LapDonHang();
            lapDonHang.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeForm thongKeForm = new ThongKeForm();
            thongKeForm.Show();
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyProduct quanlyProduct = new QuanlyProduct();
            addForm(quanlyProduct);
        }
        private void comboesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyCombo quanlyCombo = new QuanlyCombo();
            addForm(quanlyCombo);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachhang quanLyKhachhang = new QuanLyKhachhang();
            addForm(quanLyKhachhang);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanvien quanLyNhanvien = new QuanLyNhanvien();
            addForm(quanLyNhanvien);
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyHoadon quanlyHoadon = new QuanlyHoadon();
            addForm(quanlyHoadon);
        }

        private void statistcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeForm thongKeForm = new ThongKeForm();
            addForm(thongKeForm);
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapDonHang lapDonHang = new LapDonHang();
            addForm(lapDonHang);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
