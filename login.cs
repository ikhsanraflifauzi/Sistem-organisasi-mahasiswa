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
    public partial class login : KryptonForm

    {
        public login()
        {
            InitializeComponent();
        }
        public static login L = new login();
        private void btn_masuk_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text.Length == 0 || txtpass.Text.Length == 0)
                {
                    MessageBox.Show("anda belum input", "error", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection log = new SqlConnection(Connection.socket))
                    {
                        log.Open();
                        SqlCommand i = new SqlCommand("Select Username,password from tblUser where Username = @Username and password = @password", log);
                        i.Parameters.AddWithValue("@Username", txtUsername.Text);
                        i.Parameters.AddWithValue("@password", txtpass.Text);
                        SqlDataReader rd;
                        rd = i.ExecuteReader();
                        if (rd.Read())
                        {
                            if(txtUsername.Text != "bempei" && txtpass.Text != "admin")
                            {
                                MessageBox.Show("Anda telah berhasil Log in", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Dashborad us = new Dashborad();
                                us.Show();
                                us.menu_lock();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Anda telah berhasil Log in", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Dashborad das = new Dashborad();
                                das.Show();
                                this.Hide();


                            }




                        }
                        else
                        {
                            MessageBox.Show("login gagal");
                        }
                    }

                }
                

            }
            catch(Exception log)
            {
                MessageBox.Show(log.Message);

            }

        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
