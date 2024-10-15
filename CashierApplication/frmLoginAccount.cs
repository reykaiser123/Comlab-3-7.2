using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;


            Cashier cashier = new Cashier("Reynold Ardeña", username, password, "Finance");


            if (cashier.validateLogin(username, password))
            {

                MessageBox.Show($"Welcome {cashier.getFullName()} of finance");

                frmPurchaseDiscountedItem Purchaseform = new frmPurchaseDiscountedItem();
                Purchaseform.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public class UserAccount
        {

            protected string full_name;
            protected string user_name;
            protected string user_password;


            public UserAccount(string name, string uName, string password)
            {
                full_name = name;
                user_name = uName;
                user_password = password;
            }

            public bool validateLogin(string uName, string password)
            {
                return this.user_name == uName && this.user_password == password;
            }

            public string getFullName()
            {
                return full_name;
            }
        }
        public class Cashier : UserAccount
        {

            private string department;

            public Cashier(string name, string uName, string password, string department) : base(name, uName, password)
            {
                this.department = department;
            }

            public bool validateLogin(string uName, string password)
            {
                return this.user_name == uName && this.user_password == password;
            }

            public string getDepartment()
            {
                return department;
            }
        }
    }
}
