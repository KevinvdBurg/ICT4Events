using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSyteem
{
    public partial class mediaLogin : Form
    {
        private DBLogin dblogin = new DBLogin();

        public mediaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(dblogin.checkLogin(tbEmail.Text, tbWachtwoord.Text))
            {
                new MediaForm().Show();
            }
            
        }
    }
}
