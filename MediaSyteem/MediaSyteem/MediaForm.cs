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
     

        public MediaForm(Administation admin)
        {
            InitializeComponent();
            //TESTJES
            /*this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");
            this.dgvPosts.Rows.Add("Titeltje");*/
            foreach(Post p in admin.returnAllPosts())
            {
                dgvPosts.Rows.Add(p.Title, p.Likes, p.Reports);
            }
            resizeGrid();
            lblName2.Text = admin.currentAccount.Person.Name;
            lblRFID2.Text = admin.currentAccount.RFID;
            
        }

        private void btnNewPost_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 1;
        }

        private void resizeGrid()
        {
            int caseSwitch = dgvPosts.RowCount;
            switch (caseSwitch)
            {
                case 1:
                    dgvPosts.Height = 44;
                    break;
                case 2:
                    dgvPosts.Height = 66;
                    break;
                case 3:
                    dgvPosts.Height = 88;
                    break;
                case 4:
                    dgvPosts.Height = 110;
                    break;
                case 5:
                    dgvPosts.Height = 132;
                    break;
                case 6:
                    dgvPosts.Height = 154;
                    break;
                case 7:
                    dgvPosts.Height = 176;
                    break;
                case 8:
                    dgvPosts.Height = 198;
                    break;
                case 9:
                    dgvPosts.Height = 220;
                    break;
                case 10:
                    dgvPosts.Height = 242;
                    break;
                case 11:
                    dgvPosts.Height = 264;
                    break;
                default:
                    if (caseSwitch > 11)
                    {
                        dgvPosts.Height = 286;
                    }
                    
                    break;
                
                    
                
                    
            }
        }

        private void dgvPosts_DoubleClick(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 2;
        }

        private void btnSelectedPostReturn_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 0;
        }

        private void btnCancelPost_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 0;
        }

        private void btnConfirmPost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPostnaam.Text))
            {
                MessageBox.Show("Vul de titel in");


            }
            else if (string.IsNullOrEmpty(tbPostText.Text))
            {
                MessageBox.Show("Vul de inhoud in");
            }

            
            //testje
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                MessageBox.Show("Hooiiiii");
            }
        }

        private void MediaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tbFilePath.Text = openFileDialog1.FileName;
        }
        
    }
}
