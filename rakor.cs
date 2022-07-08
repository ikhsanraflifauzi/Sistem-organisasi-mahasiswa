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
using System.Data.SqlClient;

namespace UAS
{
    public partial class rakor : KryptonForm
    {
        public rakor()
        {
            InitializeComponent();
        }

        private void kryptonLabel4_Paint(object sender, PaintEventArgs e)
        {

        }
        void display()
        {
            using (SqlConnection dis = new SqlConnection(Connection.socket))
            {
                dis.Open();
                SqlDataAdapter dta = new SqlDataAdapter("select * from tbl_Proker order by NamaHima desc", dis);
                dta.SelectCommand.ExecuteNonQuery();
                DataTable dtproker = new DataTable();
                dta.Fill(dtproker);
                dgProker.DataSource = dtproker;
            }
        }
        void cari()
        {
            using (SqlConnection sea = new SqlConnection(Connection.socket))
            {
                sea.Open();
                SqlDataAdapter kotin = new SqlDataAdapter("select * from tbl_Proker where NamaHima like'%" + txt_cari.Text + "%'", sea);
                kotin.SelectCommand.ExecuteNonQuery();
                DataTable dta = new DataTable();
                kotin.Fill(dta);
                dgProker.DataSource = dta;
                txt_hima.DataBindings.Add("Text", dta, "NamaHima");
                txt_program.DataBindings.Add("Text", dta, "Program");
                txt_tujuan.DataBindings.Add("Text", dta, "Tujuan");
                txt_tgl.DataBindings.Add("Text", dta, "TanggalPelaksanaan");
                txt_ket.DataBindings.Add("Text", dta, "Keterangan");

                txt_hima.DataBindings.Clear();
                txt_program.DataBindings.Clear();
                txt_tujuan.DataBindings.Clear();
                txt_tgl.DataBindings.Clear();
                txt_ket.DataBindings.Clear();
            }
        }
        void inserting()
        {
            using (SqlConnection ins = new SqlConnection(Connection.socket))
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin akan menyimpan data ini",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ins.Open();
                    SqlCommand mas = new SqlCommand("insert into tbl_Proker values(@NamaHima,@Program,@Tujuan," +
                        "@TanggalPelaksanaan,@Keterangan)", ins);
                    mas.Parameters.AddWithValue("@NamaHima", txt_hima.Text);
                    mas.Parameters.AddWithValue("@Program", txt_program.Text);
                    mas.Parameters.AddWithValue("@Tujuan", txt_tujuan.Text);
                    mas.Parameters.AddWithValue("@TanggalPelaksanaan", txt_tgl.Text);
                    mas.Parameters.AddWithValue("@Keterangan", txt_ket.Text);
                    mas.ExecuteNonQuery();
                    MessageBox.Show("data telah tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display();
                }
                else if (dr == DialogResult.No)
                {
                    Application.Exit();
                }

            }
        }
        void updated()
        {
            try
            {
                using (SqlConnection del = new SqlConnection(Connection.socket))
                {
                    del.Open();
                    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data ini",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand uptd = new SqlCommand("Update tbl_Proker set Program = '" + txt_program.Text + "'," +
                            "Tujuan ='" + txt_tujuan.Text + "',TanggalPelaksanaan = '" + txt_tgl.Text + "'," +
                            "Keterangan ='"+txt_ket.Text+"' where NamaHima = '" + txt_hima.Text + "'", del);
                        uptd.ExecuteNonQuery();
                        MessageBox.Show("data berhasil di ubah ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        display();
                    }


                }

            }
            catch (Exception hps)
            {
                MessageBox.Show(hps.Message);
            }
        }
        void hapus()
        {
            using (SqlConnection pus = new SqlConnection(Connection.socket))
            {
                pus.Open();
                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand deleted = new SqlCommand("Delete from tbl_Proker where NamaHima ='" + txt_hima.Text + "'", pus);
                    deleted.ExecuteNonQuery();
                    MessageBox.Show("data telah terhapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display();
                }

            }
        }
        void bersih()
        {
            txt_hima.Clear();
            txt_program.Clear();
            txt_tujuan.Clear();
            txt_tgl.Clear();
            txt_ket.Clear();
        }
        private void rakor_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btn_sipan_Click(object sender, EventArgs e)
        {
            inserting();
            bersih();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            updated();
            bersih();
        }

        

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            hapus();
            bersih();
        }

        private void btn_bersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            cari();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
