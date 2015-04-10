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
    public partial class MediaForm : Form
    {
        private DBLogin dblogin = new DBLogin();

        public MediaForm()
        {
            InitializeComponent();
            Button knopje = new Button();
            knopje.Text = "nieuwe knop";
            tableLayoutPanel1.Controls.Add(knopje, 1,1);
        }

        private void btnNewPost_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 1;
        }

        
    }
}
