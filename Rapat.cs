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
    public partial class Rapat : KryptonForm
    {
        public Rapat()
        {
            InitializeComponent();
        }
        void display()
        {
            using (SqlConnection dis = new SqlConnection(Connection.socket))
            {
                dis.Open();
                SqlDataAdapter dta = new SqlDataAdapter("select * from tbRapat order by agenda_rapat desc", dis);
                dta.SelectCommand.ExecuteNonQuery();
                DataTable dtusr = new DataTable();
                dta.Fill(dtusr);
                dgRapat.DataSource = dtusr;
            }
        }
        void cari()
        {
            using (SqlConnection sea = new SqlConnection(Connection.socket))
            {
                sea.Open();
                SqlDataAdapter kotin = new SqlDataAdapter("select * from tbRapat where agenda_rapat like'%" + txt_cari.Text + "%'", sea);
                kotin.SelectCommand.ExecuteNonQuery();
                DataTable dta = new DataTable();
                kotin.Fill(dta);
                dgRapat.DataSource = dta;
                txt_agenda.DataBindings.Add("Text", dta, "agenda_rapat");
                txt_program.DataBindings.Add("Text", dta, "Program");
                txt_tanggal.DataBindings.Add("Text", dta, "Tanggal");
                txt_penyaji.DataBindings.Add("Text", dta, "Penyaji");
               

                txt_agenda.DataBindings.Clear();
                txt_program.DataBindings.Clear();
                txt_tanggal.DataBindings.Clear();
                txt_penyaji.DataBindings.Clear();
               
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
                    SqlCommand mas = new SqlCommand("insert into tbRapat values(@agenda_rapat,@Program,@Tanggal,@Penyaji)", ins);
                    mas.Parameters.AddWithValue("@agenda_rapat", txt_agenda.Text);
                    mas.Parameters.AddWithValue("@Program", txt_program.Text);
                    mas.Parameters.AddWithValue("@Tanggal", txt_tanggal.Text);
                    mas.Parameters.AddWithValue("@Penyaji", txt_penyaji.Text);
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
                        SqlCommand uptd = new SqlCommand("Update tbRapat set agenda_Rapat = '" + txt_agenda.Text + "'" +
                            ", Program = '" + txt_program.Text + "',Penyaji ='" + txt_penyaji.Text + "' where Tanggal = '" + txt_tanggal.Text + "'", del);
                        uptd.ExecuteNonQuery();
                        MessageBox.Show("data berhasil di ubah ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        display();
                    }


                }

            }
            catch(Exception up)
            {
                MessageBox.Show(up.Message);
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
                    SqlCommand deleted = new SqlCommand("Delete from tbRapat where agenda_rapat ='" + txt_agenda.Text + "'", pus);
                    deleted.ExecuteNonQuery();
                    MessageBox.Show("data telah terhapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display();
                }

            }
        }
        void bersih()
        {
            txt_agenda.Clear();
            txt_program.Clear();
            txt_tanggal.Clear();
            txt_penyaji.Clear();
        }
        private void Rapat_Load(object sender, EventArgs e)
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
    }
}
