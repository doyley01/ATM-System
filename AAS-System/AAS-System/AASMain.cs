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
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace AAS_System
{
    public partial class AASMain : Form 
    {
        AASLogin loginPage = Application.OpenForms.OfType<AASLogin>().FirstOrDefault();
        string chosenName;

        public AASMain()
        {
            InitializeComponent();
            chosenName = Convert.ToString(loginPage.GetName());
            NameTxt.Text = chosenName;
        }
        //sql connection

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1NQ2GD0,1434;Initial Catalog=CustomerDB;Persist Security Info=True;User ID=User;Password=hello");

        //functions 
        public void AddCustomer()
        {
            AddCustomer add = new AddCustomer();
            add.Show();
            this.Close();
        }

        public void ViewCustomer()
        {
            ViewCustomer view = new ViewCustomer();
            view.Show();
            this.Close();
        }

        //button presses

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewCustomer();
        }

        private void ViewTransBtn_Click(object sender, EventArgs e)
        {
            Transactions trans = new Transactions();
            trans.Show();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thankyou for using the system");
            Application.Exit();
        }
    }
}
