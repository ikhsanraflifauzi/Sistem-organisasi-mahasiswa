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

namespace UAS
{
    public partial class Tester : Form
    {
        public Tester()
        {
            InitializeComponent();
        }

        private void btn_tes_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection tes = new SqlConnection(Connection.socket))
                {
                    tes.Open();
                    MessageBox.Show("sudah terkoneksi");
                }
            }
            catch(Exception ea)
            {
                MessageBox.Show("Koneksi gagal");
            }

        }
    }
}
