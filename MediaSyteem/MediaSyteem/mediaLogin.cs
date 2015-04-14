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
        private Administation admin = new Administation();

        public mediaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(admin.login(tbEmail.Text, tbWachtwoord.Text))
            {
                admin.setCurrentAccount(tbEmail.Text);
                new MediaForm(admin).Show();
                
            }
            
        }
    }
}
