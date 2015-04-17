namespace MediaSyteem
{
    partial class MediaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbliFunction = new System.Windows.Forms.Label();
            this.lbliName = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCPosts = new System.Windows.Forms.TabControl();
            this.tabPosts = new System.Windows.Forms.TabPage();
            this.btnOpenPost = new System.Windows.Forms.Button();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.PostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postTitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dislikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewPost = new System.Windows.Forms.Button();
            this.tabNewPost = new System.Windows.Forms.TabPage();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancelPost = new System.Windows.Forms.Button();
            this.btnConfirmPost = new System.Windows.Forms.Button();
            this.lblBestand = new System.Windows.Forms.Label();
            this.tbPostText = new System.Windows.Forms.TextBox();
            this.lblPostTekst = new System.Windows.Forms.Label();
            this.tbPostnaam = new System.Windows.Forms.TextBox();
            this.lblPostNaam = new System.Windows.Forms.Label();
            this.lblPlaatsPost = new System.Windows.Forms.Label();
            this.tabSelectedPost = new System.Windows.Forms.TabPage();
            this.btnSelectedPostReturn = new System.Windows.Forms.Button();
            this.tbSelectedPost = new System.Windows.Forms.TextBox();
            this.lblSelectedPostTitle = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblRFID2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPostAuteur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReplies = new System.Windows.Forms.DataGridView();
            this.postidreply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postTitleReply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postLikesReply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostDislikesReply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCPosts.SuspendLayout();
            this.tabPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.tabNewPost.SuspendLayout();
            this.tabSelectedPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplies)).BeginInit();
            this.SuspendLayout();
            // 
            // lbliFunction
            // 
            this.lbliFunction.AutoSize = true;
            this.lbliFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliFunction.Location = new System.Drawing.Point(199, 57);
            this.lbliFunction.Name = "lbliFunction";
            this.lbliFunction.Size = new System.Drawing.Size(0, 20);
            this.lbliFunction.TabIndex = 13;
            // 
            // lbliName
            // 
            this.lbliName.AutoSize = true;
            this.lbliName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliName.Location = new System.Drawing.Point(199, 26);
            this.lbliName.Name = "lbliName";
            this.lbliName.Size = new System.Drawing.Size(0, 20);
            this.lbliName.TabIndex = 12;
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.Location = new System.Drawing.Point(115, 57);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(52, 20);
            this.lblRFID.TabIndex = 11;
            this.lblRFID.Text = "RFID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(115, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Naam:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(745, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(791, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 87);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tabCPosts
            // 
            this.tabCPosts.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabCPosts.Controls.Add(this.tabPosts);
            this.tabCPosts.Controls.Add(this.tabNewPost);
            this.tabCPosts.Controls.Add(this.tabSelectedPost);
            this.tabCPosts.ItemSize = new System.Drawing.Size(0, 1);
            this.tabCPosts.Location = new System.Drawing.Point(12, 114);
            this.tabCPosts.Multiline = true;
            this.tabCPosts.Name = "tabCPosts";
            this.tabCPosts.SelectedIndex = 0;
            this.tabCPosts.Size = new System.Drawing.Size(903, 399);
            this.tabCPosts.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCPosts.TabIndex = 14;
            // 
            // tabPosts
            // 
            this.tabPosts.Controls.Add(this.btnOpenPost);
            this.tabPosts.Controls.Add(this.dgvPosts);
            this.tabPosts.Controls.Add(this.btnNewPost);
            this.tabPosts.Location = new System.Drawing.Point(4, 5);
            this.tabPosts.Name = "tabPosts";
            this.tabPosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosts.Size = new System.Drawing.Size(895, 390);
            this.tabPosts.TabIndex = 0;
            this.tabPosts.Text = "InCheck";
            this.tabPosts.UseVisualStyleBackColor = true;
            // 
            // btnOpenPost
            // 
            this.btnOpenPost.Location = new System.Drawing.Point(138, 20);
            this.btnOpenPost.Name = "btnOpenPost";
            this.btnOpenPost.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPost.TabIndex = 3;
            this.btnOpenPost.Text = "Open post";
            this.btnOpenPost.UseVisualStyleBackColor = true;
            this.btnOpenPost.Click += new System.EventHandler(this.btnOpenPost_Click);
            // 
            // dgvPosts
            // 
            this.dgvPosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostID,
            this.postTitel,
            this.likes,
            this.dislikes});
            this.dgvPosts.Location = new System.Drawing.Point(46, 62);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPosts.Size = new System.Drawing.Size(443, 42);
            this.dgvPosts.TabIndex = 2;
            this.dgvPosts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosts_CellContentClick);
            this.dgvPosts.DoubleClick += new System.EventHandler(this.dgvPosts_DoubleClick);
            // 
            // PostID
            // 
            this.PostID.HeaderText = "PostID";
            this.PostID.Name = "PostID";
            this.PostID.ReadOnly = true;
            this.PostID.Visible = false;
            // 
            // postTitel
            // 
            this.postTitel.HeaderText = "Post titel";
            this.postTitel.Name = "postTitel";
            this.postTitel.ReadOnly = true;
            this.postTitel.Width = 200;
            // 
            // likes
            // 
            this.likes.HeaderText = "Likes";
            this.likes.Name = "likes";
            this.likes.ReadOnly = true;
            // 
            // dislikes
            // 
            this.dislikes.HeaderText = "Dislikes";
            this.dislikes.Name = "dislikes";
            this.dislikes.ReadOnly = true;
            // 
            // btnNewPost
            // 
            this.btnNewPost.Location = new System.Drawing.Point(46, 20);
            this.btnNewPost.Name = "btnNewPost";
            this.btnNewPost.Size = new System.Drawing.Size(75, 23);
            this.btnNewPost.TabIndex = 1;
            this.btnNewPost.Text = "Nieuwe post";
            this.btnNewPost.UseVisualStyleBackColor = true;
            this.btnNewPost.Click += new System.EventHandler(this.btnNewPost_Click);
            // 
            // tabNewPost
            // 
            this.tabNewPost.Controls.Add(this.tbFilePath);
            this.tabNewPost.Controls.Add(this.btnBrowse);
            this.tabNewPost.Controls.Add(this.btnCancelPost);
            this.tabNewPost.Controls.Add(this.btnConfirmPost);
            this.tabNewPost.Controls.Add(this.lblBestand);
            this.tabNewPost.Controls.Add(this.tbPostText);
            this.tabNewPost.Controls.Add(this.lblPostTekst);
            this.tabNewPost.Controls.Add(this.tbPostnaam);
            this.tabNewPost.Controls.Add(this.lblPostNaam);
            this.tabNewPost.Controls.Add(this.lblPlaatsPost);
            this.tabNewPost.Location = new System.Drawing.Point(4, 5);
            this.tabNewPost.Name = "tabNewPost";
            this.tabNewPost.Size = new System.Drawing.Size(895, 390);
            this.tabNewPost.TabIndex = 1;
            this.tabNewPost.Text = "tabPage1";
            this.tabNewPost.UseVisualStyleBackColor = true;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(221, 304);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(206, 20);
            this.tbFilePath.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(453, 304);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancelPost
            // 
            this.btnCancelPost.Location = new System.Drawing.Point(331, 345);
            this.btnCancelPost.Name = "btnCancelPost";
            this.btnCancelPost.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPost.TabIndex = 8;
            this.btnCancelPost.Text = "Annuleer";
            this.btnCancelPost.UseVisualStyleBackColor = true;
            this.btnCancelPost.Click += new System.EventHandler(this.btnCancelPost_Click);
            // 
            // btnConfirmPost
            // 
            this.btnConfirmPost.Location = new System.Drawing.Point(221, 345);
            this.btnConfirmPost.Name = "btnConfirmPost";
            this.btnConfirmPost.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmPost.TabIndex = 7;
            this.btnConfirmPost.Text = "Plaats";
            this.btnConfirmPost.UseVisualStyleBackColor = true;
            this.btnConfirmPost.Click += new System.EventHandler(this.btnConfirmPost_Click);
            // 
            // lblBestand
            // 
            this.lblBestand.AutoSize = true;
            this.lblBestand.Location = new System.Drawing.Point(34, 306);
            this.lblBestand.Name = "lblBestand";
            this.lblBestand.Size = new System.Drawing.Size(52, 13);
            this.lblBestand.TabIndex = 5;
            this.lblBestand.Text = "Bestand :";
            // 
            // tbPostText
            // 
            this.tbPostText.Location = new System.Drawing.Point(221, 95);
            this.tbPostText.MaxLength = 500;
            this.tbPostText.Multiline = true;
            this.tbPostText.Name = "tbPostText";
            this.tbPostText.Size = new System.Drawing.Size(528, 168);
            this.tbPostText.TabIndex = 4;
            // 
            // lblPostTekst
            // 
            this.lblPostTekst.AutoSize = true;
            this.lblPostTekst.Location = new System.Drawing.Point(34, 95);
            this.lblPostTekst.Name = "lblPostTekst";
            this.lblPostTekst.Size = new System.Drawing.Size(40, 13);
            this.lblPostTekst.TabIndex = 3;
            this.lblPostTekst.Text = "Teskt :";
            // 
            // tbPostnaam
            // 
            this.tbPostnaam.Location = new System.Drawing.Point(221, 64);
            this.tbPostnaam.Name = "tbPostnaam";
            this.tbPostnaam.Size = new System.Drawing.Size(206, 20);
            this.tbPostnaam.TabIndex = 2;
            // 
            // lblPostNaam
            // 
            this.lblPostNaam.AutoSize = true;
            this.lblPostNaam.Location = new System.Drawing.Point(34, 64);
            this.lblPostNaam.Name = "lblPostNaam";
            this.lblPostNaam.Size = new System.Drawing.Size(63, 13);
            this.lblPostNaam.TabIndex = 1;
            this.lblPostNaam.Text = "Post naam :";
            // 
            // lblPlaatsPost
            // 
            this.lblPlaatsPost.AutoSize = true;
            this.lblPlaatsPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaatsPost.Location = new System.Drawing.Point(30, 10);
            this.lblPlaatsPost.Name = "lblPlaatsPost";
            this.lblPlaatsPost.Size = new System.Drawing.Size(199, 39);
            this.lblPlaatsPost.TabIndex = 0;
            this.lblPlaatsPost.Text = "Plaats post!";
            // 
            // tabSelectedPost
            // 
            this.tabSelectedPost.Controls.Add(this.dgvReplies);
            this.tabSelectedPost.Controls.Add(this.btnSelectedPostReturn);
            this.tabSelectedPost.Controls.Add(this.tbSelectedPost);
            this.tabSelectedPost.Controls.Add(this.lblSelectedPostTitle);
            this.tabSelectedPost.Controls.Add(this.label1);
            this.tabSelectedPost.Controls.Add(this.lblPostAuteur);
            this.tabSelectedPost.Location = new System.Drawing.Point(4, 5);
            this.tabSelectedPost.Name = "tabSelectedPost";
            this.tabSelectedPost.Size = new System.Drawing.Size(895, 390);
            this.tabSelectedPost.TabIndex = 2;
            this.tabSelectedPost.Text = "tabPage1";
            this.tabSelectedPost.UseVisualStyleBackColor = true;
            // 
            // btnSelectedPostReturn
            // 
            this.btnSelectedPostReturn.Location = new System.Drawing.Point(7, 16);
            this.btnSelectedPostReturn.Name = "btnSelectedPostReturn";
            this.btnSelectedPostReturn.Size = new System.Drawing.Size(75, 23);
            this.btnSelectedPostReturn.TabIndex = 3;
            this.btnSelectedPostReturn.Text = "Terug";
            this.btnSelectedPostReturn.UseVisualStyleBackColor = true;
            this.btnSelectedPostReturn.Click += new System.EventHandler(this.btnSelectedPostReturn_Click);
            // 
            // tbSelectedPost
            // 
            this.tbSelectedPost.Location = new System.Drawing.Point(107, 42);
            this.tbSelectedPost.Multiline = true;
            this.tbSelectedPost.Name = "tbSelectedPost";
            this.tbSelectedPost.ReadOnly = true;
            this.tbSelectedPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSelectedPost.Size = new System.Drawing.Size(748, 186);
            this.tbSelectedPost.TabIndex = 1;
            // 
            // lblSelectedPostTitle
            // 
            this.lblSelectedPostTitle.AutoSize = true;
            this.lblSelectedPostTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPostTitle.Location = new System.Drawing.Point(100, 0);
            this.lblSelectedPostTitle.Name = "lblSelectedPostTitle";
            this.lblSelectedPostTitle.Size = new System.Drawing.Size(323, 39);
            this.lblSelectedPostTitle.TabIndex = 0;
            this.lblSelectedPostTitle.Text = "lblSelectedPostTitle";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(176, 33);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(35, 13);
            this.lblName2.TabIndex = 15;
            this.lblName2.Text = "label1";
            // 
            // lblRFID2
            // 
            this.lblRFID2.AutoSize = true;
            this.lblRFID2.Location = new System.Drawing.Point(179, 63);
            this.lblRFID2.Name = "lblRFID2";
            this.lblRFID2.Size = new System.Drawing.Size(35, 13);
            this.lblRFID2.TabIndex = 16;
            this.lblRFID2.Text = "label2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPostAuteur
            // 
            this.lblPostAuteur.AutoSize = true;
            this.lblPostAuteur.Location = new System.Drawing.Point(504, 22);
            this.lblPostAuteur.Name = "lblPostAuteur";
            this.lblPostAuteur.Size = new System.Drawing.Size(35, 13);
            this.lblPostAuteur.TabIndex = 6;
            this.lblPostAuteur.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "door:";
            // 
            // dgvReplies
            // 
            this.dgvReplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postidreply,
            this.postTitleReply,
            this.postLikesReply,
            this.PostDislikesReply});
            this.dgvReplies.Location = new System.Drawing.Point(107, 259);
            this.dgvReplies.Name = "dgvReplies";
            this.dgvReplies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReplies.Size = new System.Drawing.Size(340, 110);
            this.dgvReplies.TabIndex = 8;
            // 
            // postidreply
            // 
            this.postidreply.HeaderText = "postid";
            this.postidreply.Name = "postidreply";
            this.postidreply.ReadOnly = true;
            this.postidreply.Visible = false;
            // 
            // postTitleReply
            // 
            this.postTitleReply.HeaderText = "Titel";
            this.postTitleReply.Name = "postTitleReply";
            this.postTitleReply.ReadOnly = true;
            // 
            // postLikesReply
            // 
            this.postLikesReply.HeaderText = "Likes";
            this.postLikesReply.Name = "postLikesReply";
            this.postLikesReply.ReadOnly = true;
            // 
            // PostDislikesReply
            // 
            this.PostDislikesReply.HeaderText = "Reports";
            this.PostDislikesReply.Name = "PostDislikesReply";
            this.PostDislikesReply.ReadOnly = true;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 534);
            this.Controls.Add(this.lblRFID2);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.tabCPosts);
            this.Controls.Add(this.lbliFunction);
            this.Controls.Add(this.lbliName);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MediaForm";
            this.Text = "Media Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCPosts.ResumeLayout(false);
            this.tabPosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.tabNewPost.ResumeLayout(false);
            this.tabNewPost.PerformLayout();
            this.tabSelectedPost.ResumeLayout(false);
            this.tabSelectedPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbliFunction;
        private System.Windows.Forms.Label lbliName;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabCPosts;
        private System.Windows.Forms.TabPage tabPosts;
        private System.Windows.Forms.Button btnNewPost;
        private System.Windows.Forms.TabPage tabNewPost;
        private System.Windows.Forms.Label lblBestand;
        private System.Windows.Forms.TextBox tbPostText;
        private System.Windows.Forms.Label lblPostTekst;
        private System.Windows.Forms.TextBox tbPostnaam;
        private System.Windows.Forms.Label lblPostNaam;
        private System.Windows.Forms.Label lblPlaatsPost;
        private System.Windows.Forms.Button btnCancelPost;
        private System.Windows.Forms.Button btnConfirmPost;
        private System.Windows.Forms.TabPage tabSelectedPost;
        private System.Windows.Forms.TextBox tbSelectedPost;
        private System.Windows.Forms.Label lblSelectedPostTitle;
        private System.Windows.Forms.Button btnSelectedPostReturn;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblRFID2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn postTitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn likes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dislikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPostAuteur;
        private System.Windows.Forms.DataGridView dgvReplies;
        private System.Windows.Forms.DataGridViewTextBoxColumn postidreply;
        private System.Windows.Forms.DataGridViewTextBoxColumn postTitleReply;
        private System.Windows.Forms.DataGridViewTextBoxColumn postLikesReply;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostDislikesReply;

    }
}

