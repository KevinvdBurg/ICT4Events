using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;

namespace MediaSyteem
{
    public partial class MediaForm : Form
    {

        private Administation admini;
        private int currentPostReplies = 0;
        private int currentPost = 0;
        private int currentParentPost = 0;
        private int currentMap;
        public static string exePath = Application.StartupPath.ToString();
        //public string downloadPath = exePath + @"\Downloads";
        public string downloadPath;
        public string filePath;

        //private System.Windows.Forms.TreeView directoryTreeView;
        private string substringDirectory;

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
            admini = admin;
            currentMap = 1;
            resizeGrid(currentMap);
            lblName2.Text = admin.currentAccount.Person.Name;
            lblRFID2.Text = admin.currentAccount.RFID;
        }

        private
            void btnNewPost_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 1;
        }

        private void resizeGrid(int mapid)
        {
            dgvPosts.Rows.Clear();
            if(mapid == 1)
            {
                foreach (Post p in admini.returnAllPosts())
                {
                    dgvPosts.Rows.Add(p.Postid, p.Title, p.Likes, p.Reports);
                }
            }
            

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
            //tabCPosts.SelectedIndex = 2;
            //lblSelectedPostTitle.Text = admini.
            //tbSelectedPost.Text = admini.

        }

        private void btnSelectedPostReturn_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 0;
            resizeGrid(currentMap);
        }

        private void btnCancelPost_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 0;
            resizeGrid(currentMap);
        }

        private void btnConfirmPost_Click(object sender, EventArgs e)
        {
            bool Title = true;
            bool Inhoud = true;
            if (string.IsNullOrEmpty(tbPostnaam.Text))
            {
                MessageBox.Show("Vul de titel in");
                Title = false;

            }
            else if (string.IsNullOrEmpty(tbPostText.Text))
            {
                MessageBox.Show("Vul de inhoud in");
                Inhoud = false;
            }


            //testje
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                if (Title && Inhoud)
                {
                    if (currentPost == 0)
                    {
                        Post post = new Post(DateTime.Now, 0, 1, 0, tbPostnaam.Text, "Bericht");
                        post.Account = admini.currentAccount;
                        admini.Add(post, tbPostText.Text);
                    }
                    else
                    {
                        Post post = new Post(DateTime.Now, 0, 1, currentPost, 0, tbPostnaam.Text, "Bericht");
                        post.Account = admini.currentAccount;
                        admini.AddReply(post, tbPostText.Text);
                    }

                    tbPostnaam.Clear();
                    tbPostText.Clear();
                }
            }
            currentPost = 0;
            currentParentPost = 0;
            tabCPosts.SelectedIndex = 0;
            resizeGrid(currentMap);
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

        private void dgvPosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPosts.CurrentCell.RowIndex;
            dgvPosts.Rows[index].Selected = true;

            btnOpenPost.PerformClick();
            //MessageBox.Show(dgvPosts.SelectedRows[0].Cells["postid"].ToString());
        }

        private void btnOpenPost_Click(object sender, EventArgs e)
        {
            int gridCount = 0;
            dgvReplies.Rows.Clear();

            foreach (DataGridViewRow row in dgvPosts.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (gridCount == 0)
                    {
                        currentPost = Convert.ToInt32(cell.Value);
                        currentParentPost = 0;
                    }
                    gridCount++;
                }
            }
            lblSelectedPostTitle.Text = admini.postTitel(currentPost);
            lblPostAuteur.Text = admini.PostAuteur(currentPost);
            currentPostReplies = admini.NumberOfReplies(currentPost);

            if (admini.isMessage(currentPost))
            {
                tbSelectedPost.Text = admini.postText(currentPost);
            }
            if (currentPostReplies > 0)
            {
                foreach (Post p in admini.ReturnAllReplies(currentPost))
                {
                    dgvReplies.Rows.Add(p.Postid, p.Title, p.Likes, p.Reports);

                }
            }
            tabCPosts.SelectedIndex = 2;

        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            admini.LikePost(currentPost);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            admini.ReportPost(currentPost);
        }

        private void dgvReplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvReplies.CurrentCell.RowIndex;
            dgvReplies.Rows[index].Selected = true;

            int gridCount = 0;




            foreach (DataGridViewRow row in dgvReplies.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (gridCount == 0)
                    {
                        currentPost = Convert.ToInt32(cell.Value);
                        currentParentPost = admini.GiveParentPost(currentPost);
                    }
                    gridCount++;
                }
            }
            lblSelectedPostTitle.Text = admini.postTitel(currentPost);
            lblPostAuteur.Text = admini.PostAuteur(currentPost);
            currentPostReplies = admini.NumberOfReplies(currentPost);
            dgvReplies.Rows.Clear();

            if (admini.isMessage(currentPost))
            {
                tbSelectedPost.Text = admini.postText(currentPost);
            }
            if (currentPostReplies > 0)
            {
                foreach (Post p in admini.ReturnAllReplies(currentPost))
                {
                    dgvReplies.Rows.Add(p.Postid, p.Title, p.Likes, p.Reports);

                }
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 1;


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string temp = "";
            string downloadBestand;
            if (filePath == null || downloadPath == null || tbBestandnaam.Text == null)
            {
                MessageBox.Show("Selecteer een bestand dat je wilt downloaden, de downloadmap en geef een bestandsnaam op.");
            }
            else
            {
                try
                {
                    int lengte = filePath.Length;
                    int startindex = lengte - 3;
                    string extensie = filePath.Substring(startindex - 1, 4);
                    temp = "\\temp" + extensie;
                    downloadBestand = downloadPath + temp;
                    string renameBestand = downloadPath + "\\" + tbBestandnaam.Text + extensie;
                    if (!System.IO.File.Exists(downloadBestand))
                    {
                        // This statement ensures that the file is created, 
                        // but the handle is not kept. 
                        using (FileStream fs = System.IO.File.Create(downloadBestand)) { }
                    }

                    /*if (!System.IO.File.Exists(renameBestand))
                    {
                        // This statement ensures that the file is created, 
                        // but the handle is not kept. 
                        using (FileStream fs = System.IO.File.Create(renameBestand))
                        {
                        }
                    }*/
                    System.IO.File.Copy(filePath, downloadBestand, true);
                    System.IO.File.Move(downloadBestand, renameBestand);
                    MessageBox.Show("Bestand is gedownload.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("The process failed: {0}", ex.ToString());
                }
            }
        }

        private void btnDownloadMap_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                downloadPath = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
