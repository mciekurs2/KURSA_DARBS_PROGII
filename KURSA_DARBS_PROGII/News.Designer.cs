namespace KURSA_DARBS_PROGII
{
    partial class MainWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sourceList = new System.Windows.Forms.ComboBox();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.countryCodeList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.countryCode = new System.Windows.Forms.TextBox();
            this.bySource = new System.Windows.Forms.Label();
            this.byCategory = new System.Windows.Forms.Label();
            this.byCountryCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.newsList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.info);
            this.splitContainer1.Panel1.Controls.Add(this.source);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.divider);
            this.splitContainer1.Panel1.Controls.Add(this.category);
            this.splitContainer1.Panel1.Controls.Add(this.countryCode);
            this.splitContainer1.Panel1.Controls.Add(this.bySource);
            this.splitContainer1.Panel1.Controls.Add(this.byCategory);
            this.splitContainer1.Panel1.Controls.Add(this.byCountryCode);
            this.splitContainer1.Panel1.Controls.Add(this.tittle);
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.newsList);
            this.splitContainer1.Size = new System.Drawing.Size(743, 426);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 0;
            // 
            // sourceList
            // 
            this.sourceList.FormattingEnabled = true;
            this.sourceList.Location = new System.Drawing.Point(116, 98);
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(85, 21);
            this.sourceList.TabIndex = 12;
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(116, 66);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(85, 21);
            this.categoryList.TabIndex = 12;
            // 
            // countryCodeList
            // 
            this.countryCodeList.FormattingEnabled = true;
            this.countryCodeList.Location = new System.Drawing.Point(116, 35);
            this.countryCodeList.Name = "countryCodeList";
            this.countryCodeList.Size = new System.Drawing.Size(85, 21);
            this.countryCodeList.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sources";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CountryCodes";
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(118, 160);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(85, 20);
            this.source.TabIndex = 10;
            this.source.TextChanged += new System.EventHandler(this.Source_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(25, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 2);
            this.label1.TabIndex = 9;
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(25, 141);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(178, 2);
            this.divider.TabIndex = 9;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(118, 104);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(85, 20);
            this.category.TabIndex = 7;
            // 
            // countryCode
            // 
            this.countryCode.Location = new System.Drawing.Point(118, 70);
            this.countryCode.Name = "countryCode";
            this.countryCode.Size = new System.Drawing.Size(85, 20);
            this.countryCode.TabIndex = 7;
            this.countryCode.TextChanged += new System.EventHandler(this.CountryCode_TextChanged);
            // 
            // bySource
            // 
            this.bySource.AutoSize = true;
            this.bySource.Location = new System.Drawing.Point(22, 163);
            this.bySource.Name = "bySource";
            this.bySource.Size = new System.Drawing.Size(55, 13);
            this.bySource.TabIndex = 6;
            this.bySource.Text = "by Source";
            // 
            // byCategory
            // 
            this.byCategory.AutoSize = true;
            this.byCategory.Location = new System.Drawing.Point(22, 107);
            this.byCategory.Name = "byCategory";
            this.byCategory.Size = new System.Drawing.Size(63, 13);
            this.byCategory.TabIndex = 6;
            this.byCategory.Text = "by Category";
            // 
            // byCountryCode
            // 
            this.byCountryCode.AutoSize = true;
            this.byCountryCode.Location = new System.Drawing.Point(22, 73);
            this.byCountryCode.Name = "byCountryCode";
            this.byCountryCode.Size = new System.Drawing.Size(85, 13);
            this.byCountryCode.TabIndex = 5;
            this.byCountryCode.Text = "by Country Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(69, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Useful info";
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.tittle.Location = new System.Drawing.Point(50, 19);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(121, 17);
            this.tittle.TabIndex = 4;
            this.tittle.Text = "Search proporties";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(25, 391);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(178, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Confirm search options";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // newsList
            // 
            this.newsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.newsList.FormattingEnabled = true;
            this.newsList.Location = new System.Drawing.Point(3, 3);
            this.newsList.Name = "newsList";
            this.newsList.Size = new System.Drawing.Size(512, 419);
            this.newsList.TabIndex = 0;
            this.newsList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.NewsList_DrawItem);
            this.newsList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.NewsList_MeasureItem);
            this.newsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NewsList_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // info
            // 
            this.info.Controls.Add(this.label2);
            this.info.Controls.Add(this.sourceList);
            this.info.Controls.Add(this.label3);
            this.info.Controls.Add(this.categoryList);
            this.info.Controls.Add(this.label4);
            this.info.Controls.Add(this.countryCodeList);
            this.info.Controls.Add(this.label5);
            this.info.Location = new System.Drawing.Point(3, 201);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(206, 163);
            this.info.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "News";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListBox newsList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox countryCode;
        private System.Windows.Forms.Label bySource;
        private System.Windows.Forms.Label byCategory;
        private System.Windows.Forms.Label byCountryCode;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox sourceList;
        public System.Windows.Forms.ComboBox categoryList;
        public System.Windows.Forms.ComboBox countryCodeList;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel info;
    }
}

