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
    public partial class daftar : KryptonForm
    {
        public daftar()
        {
            InitializeComponent();
        }

        void display()
        {
            using(SqlConnection dis = new SqlConnection(Connection.socket))
            {
                dis.Open();
                SqlDataAdapter dta = new SqlDataAdapter("select * from tblUser order by Username desc", dis);
                dta.SelectCommand.ExecuteNonQuery();
                DataTable dtusr = new DataTable();
                dta.Fill(dtusr);
                dgUser.DataSource = dtusr;
            }
        }
        void cari()
        {
            using(SqlConnection sea = new SqlConnection(Connection.socket))
            {
                sea.Open();
                SqlDataAdapter kotin = new SqlDataAdapter("select * from tblUser where NamaHimpunan like'%" +txt_cari.Text + "%'",sea);
                kotin.SelectCommand.ExecuteNonQuery();
                DataTable dta = new DataTable();
                kotin.Fill(dta);
                dgUser.DataSource = dta;
                txt_agen.DataBindings.Add("Text", dta, "NamaHimpunan");
                txt_email.DataBindings.Add("Text", dta, "email");
                txt_prodi.DataBindings.Add("Text", dta, "prodi");
                txt_usr.DataBindings.Add("Text", dta, "Username");
                txt_pass.DataBindings.Add("Text", dta, "password");

                txt_agen.DataBindings.Clear();
                txt_email.DataBindings.Clear();
                txt_prodi.DataBindings.Clear();
                txt_usr.DataBindings.Clear();
                txt_pass.DataBindings.Clear();
            }
        }

        void inserting()
        {
            using(SqlConnection ins = new SqlConnection(Connection.socket))
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin akan menyimpan data ini", 
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    ins.Open();
                    SqlCommand mas = new SqlCommand("EXEC spinput @nama,@email,@prodi,@username,@pass ", ins);
                    mas.Parameters.AddWithValue("@nama", txt_agen.Text.Trim());
                    mas.Parameters.AddWithValue("@email", txt_email.Text.Trim());
                    mas.Parameters.AddWithValue("@prodi", txt_prodi.Text.Trim());
                    mas.Parameters.AddWithValue("@username", txt_usr.Text.Trim());
                    mas.Parameters.AddWithValue("@pass", txt_pass.Text.Trim());
                    mas.ExecuteNonQuery();
                    MessageBox.Show("data telah tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display();
                }
                else if(dr == DialogResult.No)
                {
                    Application.Exit();
                }

            }
        }
        void updated()
        {
            try
            {
                using(SqlConnection del = new SqlConnection(Connection.socket))
                {
                    del.Open();
                    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data ini",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        SqlCommand uptd = new SqlCommand("exec sp_update @username,@pass",del);
                        uptd.Parameters.AddWithValue("@username", txt_usr.Text);
                        uptd.Parameters.AddWithValue("@pass", txt_pass.Text);
                        uptd.ExecuteNonQuery();




                        MessageBox.Show("data berhasil di ubah ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        display();
                    }
                }
            }
            catch(Exception hps)
            {
                MessageBox.Show(hps.Message);
            }
        }

        void hapus()
        {
            using(SqlConnection pus = new SqlConnection(Connection.socket))
            {
                pus.Open();
                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    SqlCommand deleted = new SqlCommand(" EXEC sp_hapus @nama", pus);
                    deleted.Parameters.AddWithValue("@nama", txt_agen.Text);
                    deleted.ExecuteNonQuery();
                    MessageBox.Show("data telah terhapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display();
                }
            }
        }

        void bersih()
        {
            txt_agen.Clear();
            txt_email.Clear();
            txt_prodi.Clear();
            txt_usr.Clear();
            txt_pass.Clear();
        }

        private void daftar_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            updated();
            bersih();
        }

        private void btn_sipan_Click(object sender, EventArgs e)
        {
            inserting();
            bersih();

        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            
            cari();
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

        private void dgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
