using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetTracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtUsername.Text = "admin";
            txtPassword.Text = "1234";
            btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            MySqlConnection conn = new MySqlConnection("Server=lochnagar.abertay.ac.uk; Database=sql2203326; Uid=sql2203326; Pwd=iVGGteQzELna;");
            MySqlCommand cmd = new MySqlCommand("SELECT PasswordHash FROM SGUSER WHERE UserName = @userName", conn);
            cmd.Parameters.AddWithValue("@userName", userName);

            try
            {
                conn.Open();

                using MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (BCrypt.Net.BCrypt.Verify(txtPassword.Text, dataReader.GetString(0)))
                            DialogResult = DialogResult.OK;
                        else
                            lblFeedback.Text = "The credentials are incorrect.";
                    }
                }
                else
                    lblFeedback.Text = "The credentials are incorrect.";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (txtUsername.Text == "" || txtPassword.Text == "")
                lblFeedback.Text = "Please complete all fields";
            else
            {
                lblFeedback.Text = "The credentials are not correct.";
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
