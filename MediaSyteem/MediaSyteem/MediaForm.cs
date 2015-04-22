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
        private int currentPostReplies = 0; //bijhouden hoeveel replies van huidige post
        private int currentPost = 0; //bijouden welke post er is geopend
        private int currentParentPost = 0; //bijhouden waar een post een reactie op is
        //private int currentMap = 1;
        private int currentParentMap = 0;// bijhoudn in welke map er word gekeken
        public static string exePath = Application.StartupPath.ToString();
        //public string downloadPath = exePath + @"\Downloads";
        public string downloadPath;
        public string filePath;
        public string uploadFilePath;
        public string uploadMapPath;

        //private System.Windows.Forms.TreeView directoryTreeView;
        private string substringDirectory;

        public MediaForm(Administation admin)
        {
            InitializeComponent();
      
            admini = admin; //administration vanuit login scherm meegeven
            currentParentMap = 1; //standaard kijk je IN de hoofdmap
            //currentMap = 1;
            resizeGrid(); //resized de datagridviews. vult ze nu ook
            lblName2.Text = admin.currentAccount.Person.Name;
            lblRFID2.Text = admin.currentAccount.RFID;
        }

        //Geen appartje venster, maar het zijn verschillende tabjes met onzichtbare knoppen daarvan
        private void btnNewPost_Click(object sender, EventArgs e)
        {
            tabCPosts.SelectedIndex = 1;
        }
        //resized en vult dgv's
        private void resizeGrid()
        {
            //eerst leegmaken
            dgvPosts.Rows.Clear();
            dgvMap.Rows.Clear();
            //We hebben er voor gekozen om alle posts te laten zien als je in de hoofdmap zit
            //wel alleen de mappen die direct onder de hoofdmap liggen
            if(currentParentMap == 1)
            {
                foreach (Post p in admini.returnAllPosts())
                {
                    dgvPosts.Rows.Add(p.Postid, p.Title, p.Likes, p.Reports);
                }
                
                foreach(Map m in admini.ReturnMaps(currentParentMap))
                {
                    dgvMap.Rows.Add(m.Mapid,m.Name);
                }
                
                //dgvMap.Refresh();  
            }
            // Laat alle posts in de huidige map zien
            // en de mappen die in de huidige map zitten
            else
            {
                foreach (Post p in admini.returnAllPosts(currentParentMap))
                {
                    dgvPosts.Rows.Add(p.Postid, p.Title, p.Likes, p.Reports);
                }

                foreach(Map m in admini.ReturnMaps(currentParentMap))
                {
                    dgvMap.Rows.Add(m.Mapid, m.Name);
                }
            }
            //Laten zien in welke map je zit
            lblMap.Text = admini.getParentMapName(currentParentMap);
            
                
            
            //resize van posts dgv
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
            //terug naar de posts
            tabCPosts.SelectedIndex = 0;
            resizeGrid();
        }

        private void btnCancelPost_Click(object sender, EventArgs e)
        {
            //terug naar de posts
            tabCPosts.SelectedIndex = 0;
            resizeGrid();
        }

        //post plaatsen
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
            
            currentPost = 0;
            currentParentPost = 0;
            tabCPosts.SelectedIndex = 0;
            resizeGrid();
        }

        //Applicatie sluiten
        private void MediaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Browsen naar files
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                uploadFilePath = openFileDialog2.FileName;
            }
        }

        //verwijst dit gemaakt ipv elke keer klikken op een post, en dan nog op een knopje
        private void dgvPosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kijken in welke rij er word geklikt
            int index = dgvPosts.CurrentCell.RowIndex;
            dgvPosts.Rows[index].Selected = true;

            btnOpenPost.PerformClick();
            //MessageBox.Show(dgvPosts.SelectedRows[0].Cells["postid"].ToString());
        }

        //Postscherm vullen met de juiste informatie en dan wisselen naar dat scherm
        private void btnOpenPost_Click(object sender, EventArgs e)
        {
            int gridCount = 0;
            dgvReplies.Rows.Clear();
            //bijhouden welke post er is geopend
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
            //Velden vullen
            lblSelectedPostTitle.Text = admini.postTitel(currentPost);
            lblPostAuteur.Text = admini.PostAuteur(currentPost);
            currentPostReplies = admini.NumberOfReplies(currentPost);
            //als het een bericht is, haal de tekst op
            if (admini.isMessage(currentPost))
            {
                tbSelectedPost.Text = admini.postText(currentPost);
            }
            //als hij replies heeft,laat deze dan
            if (currentPostReplies > 0)
            {
                foreach (Post p in admini.ReturnAllReplies(currentPost))
                {
                    dgvReplies.Rows.Add(p.Postid, p.Title, p.Likes, p.Reports);

                }
            }
            //wisselen van scherm
            tabCPosts.SelectedIndex = 2;

        }

        private void btnLike_Click(object sender, EventArgs e)
        {   //post reporten
            admini.LikePost(currentPost);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //post reporten
            admini.ReportPost(currentPost);
        }

        private void dgvReplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kijken in welke rij er word geklikt
            int index = dgvReplies.CurrentCell.RowIndex;
            dgvReplies.Rows[index].Selected = true;

            int gridCount = 0;



            //Bijhouden welke post er is geopend
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
            //Informatie velden vullen
            lblSelectedPostTitle.Text = admini.postTitel(currentPost);
            lblPostAuteur.Text = admini.PostAuteur(currentPost);
            currentPostReplies = admini.NumberOfReplies(currentPost);
            //replies van de nu geopende post ophalen en weergeven
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
        {   //scherm wisslen
            tabCPosts.SelectedIndex = 1;


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //opnieuwstarten DUH
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hier selecteer je de path van het bestand dat je wilt downloaden
            string temp = @"C:\DropBox\SME";
            openFileDialog1.InitialDirectory = temp;
            openFileDialog1.FileName = "";
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
                    //Zorgt ervoor dat de goede extentie wordt toegevoegd aan het nieuwe bestand in de download map
                    int lengte = filePath.Length;
                    int startindex = lengte - 3;
                    string extensie = filePath.Substring(startindex - 1, 4);
                    temp = "\\temp" + extensie;
                    //De downloadPath is gekozen bij de button download map kiezen, de temp voegt een tijdelijke
                    //naam toe en de extensie van het bestand dat gedownload moet worden.
                    downloadBestand = downloadPath + temp;
                    //Deze string gebruik je straks om de naam van het gedownloade bestand te veranderen.
                    string renameBestand = downloadPath + "\\" + tbBestandnaam.Text + extensie;
                    //Als het bestand nog niet in de downloadmap staat gaat hij die aanmaken.
                    //Dit is NODIG om het bestand te downloaden!
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

                    //Nu kopieert hij het bestand dat je wilt downloaden met het tijdelijke bestand dat je had.
                    System.IO.File.Copy(filePath, downloadBestand, true);
                    //Hij veranderd de naam in je download map naar de gekozen naam
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
            //De path van de gekozen map word hier veranderd
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                downloadPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void tbBestandnaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectUploadMap_Click(object sender, EventArgs e)
        {
            string temp = @"C:\DropBox\SME";
            folderBrowserDialog2.SelectedPath = temp;
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                uploadMapPath = folderBrowserDialog2.SelectedPath;
            }
        }

        private void btnUploadBestand_Click(object sender, EventArgs e)
        {
            string temp = "";
            string uploadBestand;
            if (uploadFilePath == null || uploadMapPath == null || tbUploadbestandnaam.Text == null)
            {
                MessageBox.Show("Selecteer een bestand dat je wilt uploaden, de uploadmap en geef een bestandsnaam op.");
            }
            else
            {
                try
                {
                    //Zorgt ervoor dat de goede extentie wordt toegevoegd aan het nieuwe bestand in de download map
                    int lengte = uploadFilePath.Length;
                    int startindex = lengte - 3;
                    string extensie = uploadFilePath.Substring(startindex - 1, 4);
                    temp = "\\temp" + extensie;
                    //De downloadPath is gekozen bij de button download map kiezen, de temp voegt een tijdelijke
                    //naam toe en de extensie van het bestand dat gedownload moet worden.
                    uploadBestand = uploadMapPath + temp;
                    //Deze string gebruik je straks om de naam van het gedownloade bestand te veranderen.
                    string renameBestand = uploadMapPath + "\\" + tbUploadbestandnaam.Text + extensie;
                    //Als het bestand nog niet in de downloadmap staat gaat hij die aanmaken.
                    //Dit is NODIG om het bestand te downloaden!
                    if (!System.IO.File.Exists(uploadBestand))
                    {
                        // This statement ensures that the file is created, 
                        // but the handle is not kept. 
                        using (FileStream fs = System.IO.File.Create(uploadBestand)) { }
                    }

                    /*if (!System.IO.File.Exists(renameBestand))
                    {
                        // This statement ensures that the file is created, 
                        // but the handle is not kept. 
                        using (FileStream fs = System.IO.File.Create(renameBestand))
                        {
                        }
                    }*/

                    //Nu kopieert hij het bestand dat je wilt downloaden met het tijdelijke bestand dat je had.
                    System.IO.File.Copy(uploadFilePath, uploadBestand, true);
                    //Hij veranderd de naam in je download map naar de gekozen naam
                    System.IO.File.Move(uploadBestand, renameBestand);
                    MessageBox.Show("Bestand is geupload.");
                    long length;
                    global::File file = new global::File(DateTime.Now, 0, 1, 0, 0, tbUploadbestandnaam.Text, "Bestand", uploadFilePath, new FileInfo(uploadFilePath).Length, 1);
                    admini.Add(file, admini.currentAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The process failed: {0}", ex.ToString());
                }
            }
        }

        private void dgvMap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMap.CurrentCell.RowIndex;
            dgvMap.Rows[index].Selected = true;

            int gridCount = 0;




            foreach (DataGridViewRow row in dgvMap.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (gridCount == 0)
                    {
                        currentParentMap = Convert.ToInt32(cell.Value);
                        //currentParentPost = admini.GiveParentPost(currentPost);
                    }
                    gridCount++;
                }
            }

            resizeGrid();
            

            
            
        }

        private void btnHoofdmap_Click(object sender, EventArgs e)
        {
            currentParentMap = 1;
            resizeGrid();
        }
    }
}
