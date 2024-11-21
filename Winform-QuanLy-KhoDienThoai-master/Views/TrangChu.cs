using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneWarehouse.Views
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kho p = new kho();
            p.MdiParent = this;
            p.Show();
        }

        private void exportSlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapKho st = new NhapKho();
            st.MdiParent = this;
            st.Show();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatKho so = new XuatKho();
            so.MdiParent = this;
            so.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien ep = new NhanVien();
            ep.MdiParent = this;
            ep.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap sp = new NhaCungCap();
            sp.MdiParent = this;
            sp.Show();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TaiKhoan ac = new TaiKhoan();
            ac.MdiParent = this;
            ac.Show();
        }
    }
}
