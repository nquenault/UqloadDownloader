
namespace UqloadDownloader
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
			this.ui_Download = new System.Windows.Forms.Button();
			this.ui_URL = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ui_Filename = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ui_OpenDownloads = new System.Windows.Forms.Button();
			this.listView1 = new UqloadDownloader.ListViewNF();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// ui_Download
			// 
			this.ui_Download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ui_Download.Location = new System.Drawing.Point(12, 69);
			this.ui_Download.Name = "ui_Download";
			this.ui_Download.Size = new System.Drawing.Size(741, 33);
			this.ui_Download.TabIndex = 0;
			this.ui_Download.Text = "Download";
			this.ui_Download.UseVisualStyleBackColor = true;
			this.ui_Download.Click += new System.EventHandler(this.button1_Click);
			// 
			// ui_URL
			// 
			this.ui_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ui_URL.Location = new System.Drawing.Point(139, 12);
			this.ui_URL.Name = "ui_URL";
			this.ui_URL.Size = new System.Drawing.Size(614, 20);
			this.ui_URL.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Download URL :";
			// 
			// ui_Filename
			// 
			this.ui_Filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ui_Filename.Location = new System.Drawing.Point(140, 43);
			this.ui_Filename.Name = "ui_Filename";
			this.ui_Filename.Size = new System.Drawing.Size(613, 20);
			this.ui_Filename.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "(opt) File Name :";
			// 
			// ui_OpenDownloads
			// 
			this.ui_OpenDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ui_OpenDownloads.Location = new System.Drawing.Point(12, 108);
			this.ui_OpenDownloads.Name = "ui_OpenDownloads";
			this.ui_OpenDownloads.Size = new System.Drawing.Size(741, 33);
			this.ui_OpenDownloads.TabIndex = 7;
			this.ui_OpenDownloads.Text = "Open Downloads folder";
			this.ui_OpenDownloads.UseVisualStyleBackColor = true;
			this.ui_OpenDownloads.Click += new System.EventHandler(this.button2_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listView1.Location = new System.Drawing.Point(12, 147);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(741, 275);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 368;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Progress";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 56;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Rate";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 72;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "ETA";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 113;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Status";
			this.columnHeader5.Width = 120;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Orange;
			this.ClientSize = new System.Drawing.Size(766, 434);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.ui_OpenDownloads);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ui_Filename);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ui_URL);
			this.Controls.Add(this.ui_Download);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Uqload Downloader";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ui_Download;
        private System.Windows.Forms.TextBox ui_URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ui_Filename;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ui_OpenDownloads;
		private ListViewNF listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
	}
}

