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
    public partial class LaporanRapat : KryptonForm
    {
        public LaporanRapat()
        {
            InitializeComponent();
        }

        private void kryptonLabel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

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
                    SqlCommand mas = new SqlCommand("insert into tbl_laporan values(@agenda,@programKerja,@HasilRapat,@Tanggal)", ins);
                    mas.Parameters.AddWithValue("@agenda", txt_agenda.Text);
                    mas.Parameters.AddWithValue("@programKerja", txt_program.Text);
                    mas.Parameters.AddWithValue("@HasilRapat", txt_hasil.Text);
                    mas.Parameters.AddWithValue("@Tanggal", txt_tgl.Text);
                    mas.ExecuteNonQuery();
                    MessageBox.Show("data telah tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else if (dr == DialogResult.No)
                {
                    Application.Exit();
                }

            }
        }
        public static string agen, proker, hasil, tgl;
        private void LaporanRapat_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            inserting();
            string a, p, h, t;
            a = txt_agenda.Text;
            agen = a;

            p = txt_program.Text;
            proker = p;

            h = txt_hasil.Text;
            hasil = h;

            t = txt_tgl.Text;
            tgl = t;

            CetakLaporan frmCetak = new CetakLaporan();
            frmCetak.Show();
            this.Hide();

            

        }
    }
}
