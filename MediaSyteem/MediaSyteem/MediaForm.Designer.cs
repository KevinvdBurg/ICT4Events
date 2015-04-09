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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewPost = new System.Windows.Forms.Button();
            this.tabNewPost = new System.Windows.Forms.TabPage();
            this.lblPlaatsPost = new System.Windows.Forms.Label();
            this.lblPostNaam = new System.Windows.Forms.Label();
            this.tbPostnaam = new System.Windows.Forms.TextBox();
            this.lblPostTekst = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBestand = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnConfirmPost = new System.Windows.Forms.Button();
            this.btnCancelPost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCPosts.SuspendLayout();
            this.tabPosts.SuspendLayout();
            this.tabNewPost.SuspendLayout();
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
            this.tabCPosts.ItemSize = new System.Drawing.Size(20, 20);
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
            this.tabPosts.Controls.Add(this.btnNewPost);
            this.tabPosts.Controls.Add(this.tableLayoutPanel1);
            this.tabPosts.Location = new System.Drawing.Point(4, 24);
            this.tabPosts.Name = "tabPosts";
            this.tabPosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosts.Size = new System.Drawing.Size(895, 371);
            this.tabPosts.TabIndex = 0;
            this.tabPosts.Text = "InCheck";
            this.tabPosts.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 77);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(800, 2000);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewPost
            // 
            this.btnNewPost.Location = new System.Drawing.Point(7, 36);
            this.btnNewPost.Name = "btnNewPost";
            this.btnNewPost.Size = new System.Drawing.Size(75, 23);
            this.btnNewPost.TabIndex = 1;
            this.btnNewPost.Text = "Nieuwe post";
            this.btnNewPost.UseVisualStyleBackColor = true;
            this.btnNewPost.Click += new System.EventHandler(this.btnNewPost_Click);
            // 
            // tabNewPost
            // 
            this.tabNewPost.Controls.Add(this.btnCancelPost);
            this.tabNewPost.Controls.Add(this.btnConfirmPost);
            this.tabNewPost.Controls.Add(this.textBox2);
            this.tabNewPost.Controls.Add(this.lblBestand);
            this.tabNewPost.Controls.Add(this.textBox1);
            this.tabNewPost.Controls.Add(this.lblPostTekst);
            this.tabNewPost.Controls.Add(this.tbPostnaam);
            this.tabNewPost.Controls.Add(this.lblPostNaam);
            this.tabNewPost.Controls.Add(this.lblPlaatsPost);
            this.tabNewPost.Location = new System.Drawing.Point(4, 24);
            this.tabNewPost.Name = "tabNewPost";
            this.tabNewPost.Size = new System.Drawing.Size(895, 371);
            this.tabNewPost.TabIndex = 1;
            this.tabNewPost.Text = "tabPage1";
            this.tabNewPost.UseVisualStyleBackColor = true;
            // 
            // lblPlaatsPost
            // 
            this.lblPlaatsPost.AutoSize = true;
            this.lblPlaatsPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaatsPost.Location = new System.Drawing.Point(27, 43);
            this.lblPlaatsPost.Name = "lblPlaatsPost";
            this.lblPlaatsPost.Size = new System.Drawing.Size(199, 39);
            this.lblPlaatsPost.TabIndex = 0;
            this.lblPlaatsPost.Text = "Plaats post!";
            // 
            // lblPostNaam
            // 
            this.lblPostNaam.AutoSize = true;
            this.lblPostNaam.Location = new System.Drawing.Point(34, 127);
            this.lblPostNaam.Name = "lblPostNaam";
            this.lblPostNaam.Size = new System.Drawing.Size(63, 13);
            this.lblPostNaam.TabIndex = 1;
            this.lblPostNaam.Text = "Post naam :";
            // 
            // tbPostnaam
            // 
            this.tbPostnaam.Location = new System.Drawing.Point(221, 127);
            this.tbPostnaam.Name = "tbPostnaam";
            this.tbPostnaam.Size = new System.Drawing.Size(206, 20);
            this.tbPostnaam.TabIndex = 2;
            // 
            // lblPostTekst
            // 
            this.lblPostTekst.AutoSize = true;
            this.lblPostTekst.Location = new System.Drawing.Point(37, 164);
            this.lblPostTekst.Name = "lblPostTekst";
            this.lblPostTekst.Size = new System.Drawing.Size(40, 13);
            this.lblPostTekst.TabIndex = 3;
            this.lblPostTekst.Text = "Teskt :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 127);
            this.textBox1.TabIndex = 4;
            // 
            // lblBestand
            // 
            this.lblBestand.AutoSize = true;
            this.lblBestand.Location = new System.Drawing.Point(40, 306);
            this.lblBestand.Name = "lblBestand";
            this.lblBestand.Size = new System.Drawing.Size(52, 13);
            this.lblBestand.TabIndex = 5;
            this.lblBestand.Text = "Bestand :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 306);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 6;
            // 
            // btnConfirmPost
            // 
            this.btnConfirmPost.Location = new System.Drawing.Point(221, 345);
            this.btnConfirmPost.Name = "btnConfirmPost";
            this.btnConfirmPost.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmPost.TabIndex = 7;
            this.btnConfirmPost.Text = "Plaats";
            this.btnConfirmPost.UseVisualStyleBackColor = true;
            // 
            // btnCancelPost
            // 
            this.btnCancelPost.Location = new System.Drawing.Point(331, 345);
            this.btnCancelPost.Name = "btnCancelPost";
            this.btnCancelPost.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPost.TabIndex = 8;
            this.btnCancelPost.Text = "Annuleer";
            this.btnCancelPost.UseVisualStyleBackColor = true;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 534);
            this.Controls.Add(this.tabCPosts);
            this.Controls.Add(this.lbliFunction);
            this.Controls.Add(this.lbliName);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MediaForm";
            this.Text = "Media Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCPosts.ResumeLayout(false);
            this.tabPosts.ResumeLayout(false);
            this.tabNewPost.ResumeLayout(false);
            this.tabNewPost.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNewPost;
        private System.Windows.Forms.TabPage tabNewPost;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBestand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPostTekst;
        private System.Windows.Forms.TextBox tbPostnaam;
        private System.Windows.Forms.Label lblPostNaam;
        private System.Windows.Forms.Label lblPlaatsPost;
        private System.Windows.Forms.Button btnCancelPost;
        private System.Windows.Forms.Button btnConfirmPost;

    }
}

