using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOrderSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        
        
        Admin admin = new Admin();
        
        

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txbx_Login.Text.ToString()==admin.Name && txbx_Password.Text==admin.Password.ToString())
            {
                this.Hide();
                Form1 MainForm = new Form1(this);
                MainForm.Show();
            }
            else { MessageBox.Show("Login ve Password duzgun daxil edilmeyib"); }
           
        }
    }
}
