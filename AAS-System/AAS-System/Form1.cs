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
using System.Security.Cryptography;
using System.Net.Http.Headers;

namespace AAS_System
{
    public partial class AASLogin : Form
    {
        public AASLogin()
        {
            InitializeComponent();
        }
        BankEmployee employee = new BankEmployee();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1NQ2GD0,1434;Initial Catalog=CustomerDB;Persist Security Info=True;User ID=User;Password=hello");


        string username;
        string password;
        string name;
        string box_title = "ERROR";
        string box_description = "INCORRECT USERNAME OR PASSWORD";

        private void VerifyLogin()
        {
            username = UsernameTxt.Text;
            password = PasswordTxt.Text;

            try
            {
                string query = "SELECT * FROM AASLogin WHERE username = '" + UsernameTxt.Text + "' AND password = '" + PasswordTxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = UsernameTxt.Text;
                    password = PasswordTxt.Text;
                    AASMain main = new AASMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(box_description, box_title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            
                    PasswordTxt.Clear();
                    UsernameTxt.Clear();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public string GetName()
        {
            using(var connection = new SqlConnection(conn.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT firstName +' '+ lastName as Name FROM AASLogin WHERE username = '" + UsernameTxt.Text + "'", conn);
                conn.Open();
                try
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            return dr.GetValue(0).ToString();
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }

        private void ClearText()
        {
            UsernameTxt.Text = null;
            PasswordTxt.Text = null;
        }

    
        //button presses for page
        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            VerifyLogin();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        //Checkbox code
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //to show/deshow password
        {
            if (checkBox1.Checked)
            {
                PasswordTxt.UseSystemPasswordChar = true;
                var checkPass = (CheckBox)sender;
                checkPass.Text = "Show Password";
            }
            else
            {
                PasswordTxt.UseSystemPasswordChar = false;
                var checkPass = (CheckBox)sender;
                checkPass.Text = "Hide Password";
            }
        }
    }
}
