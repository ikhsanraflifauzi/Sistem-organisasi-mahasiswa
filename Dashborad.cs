using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace UAS
{
    public partial class Dashborad : KryptonForm
    {
        public Dashborad()
        {
            InitializeComponent();
        }
        public void menu_lock()
        {
            dtUser.Enabled = false;
        }

        private void Dashborad_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dashborad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frm_login = new login();
            frm_login.Show();
            this.Hide();
        }

        private void dtUser_Click(object sender, EventArgs e)
        {
            daftar frmdf = new daftar();
            frmdf.MdiParent = this;
            frmdf.Show();
        }

        private void rapatKoordinasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rakor frmRkr = new rakor();
            frmRkr.MdiParent = this;
            frmRkr.Show();
        }

        private void agendaRapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapat frmRapat = new Rapat();
            frmRapat.MdiParent = this;
            frmRapat.Show();
        }

        private void laporanRapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaporanRapat frmLap = new LaporanRapat();
            frmLap.MdiParent = this;
            frmLap.Show();
        }

        private void hasilRapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CetakLaporan frmctk = new CetakLaporan();
            frmctk.MdiParent = this;
            frmctk.Show();
        }
    }
}
