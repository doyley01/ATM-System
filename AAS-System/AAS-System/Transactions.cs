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
using Microsoft.VisualBasic;

namespace AAS_System
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1NQ2GD0,1434;Initial Catalog=CustomerDB;Persist Security Info=True;User ID=User;Password=hello"); //sql connection
        List<TextBox> textboxes = new List<TextBox>();
        
        private void DisplayName()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT firstName, lastName, address FROM Customer WHERE customerId = '" + int.Parse(CustTxt.Text) + "'", conn);
                SqlDataReader re = cmd.ExecuteReader();
                while(re.Read())
                {
                    FirstNameTxt.Text = re.GetValue(0).ToString();
                    LastNameTxt.Text = re.GetValue(1).ToString();
                    AddressTxt.Text = re.GetValue(2).ToString();
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

        private void DisplayToGrid()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM (SELECT TOP 10 transactionId, date, accountId, type, [to / from], amount FROM Transactions WHERE customerId = '" + int.Parse(CustTxt.Text) + "' ORDER BY transactionId DESC) a ORDER BY transactionId;", conn); // Selects bottom 10 ordered ascending
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                if (dataset.Tables[0].Rows.Count == 0)
                {
                    throw new IOException();
                }
                TransactionDataView.DataSource = dataset.Tables[0];
                CheckPopUp();
            }
            catch
            {
                PopUpPanel.Visible = true;
                MessageBox.Show("ERROR PLEASE ENTER VALID CUSTOMERID");
            }
            finally
            {
                conn.Close();
            }
        }

        public void CheckPopUp()
        {
            if(CustTxt.Text == "")
            {
                PopUpPanel.Visible = true; 
            }
            else
            {
                PopUpPanel.Visible = false;
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            DisplayToGrid();
            DisplayName();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
           
        }

        private void TransactionDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TransactionDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.TransactionDataView.Rows[e.RowIndex];

                IdTxt.Text = Row.Cells[0].Value.ToString();
                DateTxt.Text = Convert.ToDateTime(Row.Cells[1].Value).ToString("dd/MM/yyyy");
                FromAccountTxt.Text = Row.Cells[2].Value.ToString();
                TypeTxt.Text = Row.Cells[3].Value.ToString();
                ToAccountTxt.Text = Row.Cells[4].Value.ToString();
                AmountTxt.Text = Row.Cells[5].Value.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AASMain aas = new AASMain();
            aas.Show();
            this.Hide();
        }

        private void IdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DateTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FromAccountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TypeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ToAccountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
