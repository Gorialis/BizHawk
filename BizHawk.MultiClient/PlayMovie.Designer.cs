﻿namespace BizHawk.MultiClient
{
    partial class PlayMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMovie));
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.BrowseMovies = new System.Windows.Forms.Button();
            this.MovieView = new BizHawk.VirtualListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.DetailsView = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MovieCount = new System.Windows.Forms.Label();
            this.ReadOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(628, 361);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(537, 361);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "&Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // BrowseMovies
            // 
            this.BrowseMovies.Location = new System.Drawing.Point(12, 366);
            this.BrowseMovies.Name = "BrowseMovies";
            this.BrowseMovies.Size = new System.Drawing.Size(75, 23);
            this.BrowseMovies.TabIndex = 2;
            this.BrowseMovies.Text = "Browse...";
            this.BrowseMovies.UseVisualStyleBackColor = true;
            this.BrowseMovies.Click += new System.EventHandler(this.BrowseMovies_Click);
            // 
            // MovieView
            // 
            this.MovieView.AllowDrop = true;
            this.MovieView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.MovieView.GridLines = true;
            this.MovieView.HideSelection = false;
            this.MovieView.ItemCount = 0;
            this.MovieView.Location = new System.Drawing.Point(12, 28);
            this.MovieView.MultiSelect = false;
            this.MovieView.Name = "MovieView";
            this.MovieView.selectedItem = -1;
            this.MovieView.Size = new System.Drawing.Size(413, 303);
            this.MovieView.TabIndex = 3;
            this.MovieView.UseCompatibleStateImageBehavior = false;
            this.MovieView.View = System.Windows.Forms.View.Details;
            this.MovieView.SelectedIndexChanged += new System.EventHandler(this.MovieView_SelectedIndexChanged);
            this.MovieView.DoubleClick += new System.EventHandler(this.MovieView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SysID";
            this.columnHeader2.Width = 42;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Game";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Length";
            this.columnHeader4.Width = 97;
            // 
            // DetailsView
            // 
            this.DetailsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.DetailsView.GridLines = true;
            this.DetailsView.Location = new System.Drawing.Point(15, 19);
            this.DetailsView.Name = "DetailsView";
            this.DetailsView.Size = new System.Drawing.Size(228, 226);
            this.DetailsView.TabIndex = 4;
            this.DetailsView.UseCompatibleStateImageBehavior = false;
            this.DetailsView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Header";
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 121;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DetailsView);
            this.groupBox1.Location = new System.Drawing.Point(444, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Subtitles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Comments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieCount
            // 
            this.MovieCount.AutoSize = true;
            this.MovieCount.Location = new System.Drawing.Point(13, 338);
            this.MovieCount.Name = "MovieCount";
            this.MovieCount.Size = new System.Drawing.Size(31, 13);
            this.MovieCount.TabIndex = 7;
            this.MovieCount.Text = "        ";
            // 
            // ReadOnlyCheckBox
            // 
            this.ReadOnlyCheckBox.AutoSize = true;
            this.ReadOnlyCheckBox.Checked = true;
            this.ReadOnlyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReadOnlyCheckBox.Location = new System.Drawing.Point(131, 370);
            this.ReadOnlyCheckBox.Name = "ReadOnlyCheckBox";
            this.ReadOnlyCheckBox.Size = new System.Drawing.Size(74, 17);
            this.ReadOnlyCheckBox.TabIndex = 8;
            this.ReadOnlyCheckBox.Text = "Read only";
            this.ReadOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlayMovie
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(715, 401);
            this.Controls.Add(this.ReadOnlyCheckBox);
            this.Controls.Add(this.MovieCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MovieView);
            this.Controls.Add(this.BrowseMovies);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayMovie";
            this.Text = "Play Movie";
            this.Load += new System.EventHandler(this.PlayMovie_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button BrowseMovies;
        private VirtualListView MovieView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView DetailsView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MovieCount;
        private System.Windows.Forms.CheckBox ReadOnlyCheckBox;
    }
}