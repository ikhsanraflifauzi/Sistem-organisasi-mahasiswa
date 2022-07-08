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
    public partial class cobaCari : KryptonForm
    {
        public cobaCari()
        {
            InitializeComponent();
        }

        private void cobaCari_Load(object sender, EventArgs e)
        {
            tmpl();
            
        }
        void tmpl()
        {
            try
            {
                using (SqlConnection cari = new SqlConnection(Connection.socket))
                {
                    cari.Open();
                    SqlDataAdapter ad = new SqlDataAdapter("EXEC spDATA", cari);
                    ad.SelectCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dgvData.DataSource = dt;

                }


            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }

        }

        private void Txtcari_TextChanged(object sender, EventArgs e)
        {

            sorting();
        }
        void sorting()
        {
            try
            {
                using (SqlConnection tx = new SqlConnection(Connection.socket))
                {
                    tx.Open();
                    SqlDataAdapter dad = new SqlDataAdapter(" EXEC spUser @Nama", tx);
                    dad.SelectCommand.Parameters.AddWithValue("@Nama", Txtcari.Text.Trim());
                    dad.SelectCommand.ExecuteNonQuery();
                    DataTable tb = new DataTable();
                    dad.Fill(tb);
                    dgvData.DataSource = tb;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
