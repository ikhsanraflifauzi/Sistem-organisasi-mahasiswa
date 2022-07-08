using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
namespace UAS
{
    public partial class CetakLaporan : KryptonForm
    {
        public CetakLaporan()
        {
            InitializeComponent();
        }
        void display()
        {
            using (SqlConnection dis = new SqlConnection(Connection.socket))
            {
                dis.Open();
                SqlDataAdapter dta = new SqlDataAdapter("select * from tbl_laporan order by agenda desc", dis);
                dta.SelectCommand.ExecuteNonQuery();
                DataTable dtusr = new DataTable();
                dta.Fill(dtusr);
                dgLR.DataSource = dtusr;
            }
            
        }
        void cari()
        {
            using (SqlConnection sea = new SqlConnection(Connection.socket))
            {
                sea.Open();
                SqlDataAdapter kotin = new SqlDataAdapter("select * from tbl_laporan where agenda like'%" + txt_cari.Text + "%'", sea);
                kotin.SelectCommand.ExecuteNonQuery();
                DataTable dta = new DataTable();
                kotin.Fill(dta);
                dgLR.DataSource = dta;
                lbl_agenda.DataBindings.Add("Text", dta, "agenda");
                lblPorker.DataBindings.Add("Text", dta, "programKerja");
                lbl_tgl.DataBindings.Add("Text", dta, "Tanggal");
                lbl_hasil.DataBindings.Add("Text", dta, "HasilRapat");


                lbl_agenda.DataBindings.Clear();
                lblPorker.DataBindings.Clear();
                lbl_tgl.DataBindings.Clear();
                lbl_hasil.DataBindings.Clear();

            }
        }
        private void CetakLaporan_Load(object sender, EventArgs e)
        {
            display();
            lbl_agenda.Text = LaporanRapat.agen;
            lblPorker.Text = LaporanRapat.proker;
            lbl_tgl.Text = LaporanRapat.tgl;
            lbl_hasil.Text = LaporanRapat.hasil;
        }

        private void kryptonLabel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            cari();
        }
    }
}
