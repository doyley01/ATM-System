using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAS_System
{
    public partial class AddCustomer : Form
    {
        private string idFile = "idFile.txt";
        private int accountId;

        public AddCustomer()
        {
            InitializeComponent();
            if (File.Exists(idFile))
            {
                accountId = Convert.ToInt32(File.ReadAllText(idFile));
            }
            else
            {
                MessageBox.Show("Error locating 'idFile.txt'.");
                Environment.Exit(0);
            }
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1NQ2GD0,1434;Initial Catalog=CustomerDB;Persist Security Info=True;User ID=User;Password=hello");

        public void CreateAccount()
        {
            float overdraft;
            if (Convert.ToSingle(SalaryTxt.Text) < 30000)
            {
                overdraft = 0;
            }
            else
            {
                overdraft = ((float)(Convert.ToSingle(SalaryTxt.Text) * 0.1));
            }

            try
            {
                string Insert = "INSERT INTO Customer (customerId, firstName, lastName, address, age, annualSalary, PIN, accountDisabled, overdraft) VALUES('" + CustIDTxt.Text + "', '" + FirstNameTxt.Text + "', '" + LastNameTxt.Text + "', '" + AddressTxt.Text + "', '" + AgeTxt.Text + "', '" + SalaryTxt.Text + "', '" + PinTxt.Text + "', '0', '" + overdraft + "')";
                conn.Open();
                SqlCommand command1 = new SqlCommand(Insert, conn);
                command1.ExecuteNonQuery();
                conn.Close();

                string addBanks = "INSERT INTO BankAccount (accountId, accountType, accountName, balance, isActive, customerId) VALUES " +
                    "('" + accountId + "', '1', 'Current Account', '" + balTxt.Text + "', '1', '" + CustIDTxt.Text + "'), " +
                    "('" + (accountId + 1) + "', '2', 'Simple Deposit', '0', '0', '" + CustIDTxt.Text + "'), " +
                    "('" + (accountId + 2) + "', '3', 'Longterm Deposit', '0', '0', '" + CustIDTxt.Text + "')";
                conn.Open();
                SqlCommand command2 = new SqlCommand(addBanks, conn);
                command2.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Customer and bank accounts successfully opened.");

                accountId += 3;
                File.WriteAllText(idFile, accountId.ToString());
            }
            catch
            {
                MessageBox.Show("Error, please try again");
            }
            finally
            {
                ClearValues();
                conn.Close();
            } 
        }

       public void ClearValues()
        {
            AddressTxt.Text = null;
            AgeTxt.Text = null;
            CustIDTxt.Text = null;
            FirstNameTxt.Text = null;
            LastNameTxt.Text = null;
            PinTxt.Text = null;
            SalaryTxt.Text = null;
            balTxt.Text = null;
        }

       
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            CreateAccount();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AASMain aas = new AASMain();
            aas.Show();
            this.Hide();
        }
    }
}
