using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AAS_System
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
            PasswordPanel.Visible = false;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1NQ2GD0,1434;Initial Catalog=CustomerDB;Persist Security Info=True;User ID=User;Password=hello"); //sql connection

        string password;
        string box_title = "ERROR";
        string box_description = "INCORRECT PASSWORD";

        //functions to manage button presses
        private void SelectInfo()
        {

            try
            {
                conn.Open();
                SqlCommand command1 = new SqlCommand("SELECT firstName, lastName, address, age, annualSalary, PIN, accountDisabled, overdraft FROM Customer WHERE customerId = '" + int.Parse(CustIDTxt.Text) + "'", conn); //select values
                SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read()) //insert values into textbox and convert to string
                {
                    FirstNameTxt.Text = reader1.GetValue(0).ToString();
                    LastNameTxt.Text = reader1.GetValue(1).ToString();
                    AddressTxt.Text = reader1.GetValue(2).ToString();
                    AgeTxt.Text = reader1.GetValue(3).ToString();
                    SalaryTxt.Text = reader1.GetValue(4).ToString();
                    PinTxt.Text = reader1.GetValue(5).ToString();
                    if (Convert.ToBoolean(reader1[6]) == true)
                    {
                        accBlockedcbox.Checked = true;
                    }
                    else accBlockedcbox.Checked = false;
                    OverdraftTxt.Text = reader1.GetValue(7).ToString();
                }
                reader1.Close();

                SqlCommand command2 = new SqlCommand("SELECT isActive FROM BankAccount WHERE customerId = '" + int.Parse(CustIDTxt.Text) + "' AND accountType = '2'", conn);
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    if (Convert.ToBoolean(reader2[0]) == true)
                    {
                        SDcbox.Checked = true;
                    }
                    else SDcbox.Checked = false;
                }
                reader2.Close();

                SqlCommand command3 = new SqlCommand("SELECT isActive FROM BankAccount WHERE customerId = '" + int.Parse(CustIDTxt.Text) + "' AND accountType = '3'", conn);
                SqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    if (Convert.ToBoolean(reader3[0]) == true)
                    {
                        LDcbox.Checked = true;
                    }
                    else LDcbox.Checked = false;
                }
                reader3.Close();
            }
            catch(Exception e)
            {
                if(CustIDTxt != null)
                {
                    MessageBox.Show("ERROR PLEASE ENTER CUSTOMER ID");
                }  
               
            }
            finally
            {
                conn.Close();
            }
        }

        private void ResetValues()
        {
            CustIDTxt.Text = null;
            FirstNameTxt.Text = null;
            LastNameTxt.Text = null;
            PinTxt.Text = null; 
            OverdraftTxt.Text = null;
            AddressTxt.Text = null;
            AgeTxt.Text = null;
            SalaryTxt.Text = null;
            OverdraftTxt.Text = null;
            accBlockedcbox.Checked = false;
            SDcbox.Checked = false;
            LDcbox.Checked = false;
        }

        private void DeleteCustomer()
        {

            if (CustIDTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to remove this customer from the system?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand delcommand1 = new SqlCommand("DELETE FROM Transactions WHERE customerId = '" + int.Parse(CustIDTxt.Text) + "'", conn);
                    delcommand1.ExecuteNonQuery();
                    SqlCommand delcommand2 = new SqlCommand("DELETE FROM BankAccount WHERE customerId = '" + int.Parse(CustIDTxt.Text) + "'", conn);
                    delcommand2.ExecuteNonQuery();
                    SqlCommand delcommand3 = new SqlCommand("DELETE FROM Customer WHERE customerId =   '" + int.Parse(CustIDTxt.Text) + "'", conn);
                    delcommand3.ExecuteNonQuery();
                    ResetValues();
                    conn.Close();
                }
                else
                {
                    PasswordTxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter the CustomerID to display details");
            }
        }
        private void OpenTransaction()
        {
            Transactions trans = new Transactions();
            trans.Show();
            this.Close();
        }

        private void UpdateCustomerDetails()
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE Customer SET firstName = '" + FirstNameTxt.Text + "', lastName = '" + LastNameTxt.Text + "', address = '" + AddressTxt.Text + "', age = '" + AgeTxt.Text + "', annualSalary = '" + SalaryTxt.Text + "', PIN = '" + PinTxt.Text + "', overdraft = '" + OverdraftTxt.Text + "', accountDisabled = '" + accBlockedcbox.Checked + "' WHERE customerId = '" + int.Parse(CustIDTxt.Text) + "'", conn);
                cmd1.ExecuteNonQuery();

                if (SDcbox.Checked)
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BankAccount SET isActive = '1' WHERE customerId = '" + int.Parse(CustIDTxt.Text) + "' AND accountType = '2';", conn);
                    cmd2.ExecuteNonQuery();
                }

                if (LDcbox.Checked)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE BankAccount SET isActive = '1' WHERE customerId = '" + int.Parse(CustIDTxt.Text) + "' AND accountType = '3';", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please enter customerID to access customer");
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Details have succesfully been updated");
                ResetValues();
            }
        }

        private void CheckPassword()
        {
            password = ConfirmPassTxt.Text;

            try
            {
                string query = "SELECT * FROM AASLogin WHERE password = '" + PasswordTxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    password = ConfirmPassTxt.Text;
                    PasswordPanel.Visible = false;
                    DeleteCustomer();
                   
                   
                }
                else
                {
                    MessageBox.Show(box_description, box_title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    PasswordTxt.Clear();
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

        //button presses

        private void button1_Click(object sender, EventArgs e)
        {
            SelectInfo();
        }

    
        private void button3_Click(object sender, EventArgs e)
        {
            PasswordPanel.Visible = true;
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AASMain aas = new AASMain();
            aas.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCustomerDetails();
        }

        private void ConfirmPassTxt_Click(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PasswordPanel.Visible = false;
            PasswordTxt.Text = "";
        }
    }
}
