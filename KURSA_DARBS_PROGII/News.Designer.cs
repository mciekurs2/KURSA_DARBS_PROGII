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
            this.newsList = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tittle = new System.Windows.Forms.Label();
            this.byCountryCode = new System.Windows.Forms.Label();
            this.byCategory = new System.Windows.Forms.Label();
            this.bySource = new System.Windows.Forms.Label();
            this.countryCode = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.source = new System.Windows.Forms.ComboBox();
            this.divider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.divider);
            this.splitContainer1.Panel1.Controls.Add(this.source);
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
            this.splitContainer1.Size = new System.Drawing.Size(743, 450);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 0;
            // 
            // newsList
            // 
            this.newsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.newsList.FormattingEnabled = true;
            this.newsList.Location = new System.Drawing.Point(3, 3);
            this.newsList.Name = "newsList";
            this.newsList.Size = new System.Drawing.Size(512, 445);
            this.newsList.TabIndex = 0;
            this.newsList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.NewsList_DrawItem);
            this.newsList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.NewsList_MeasureItem);
            this.newsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.newsList_MouseDoubleClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(25, 415);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(178, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Confirm search options";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            // byCountryCode
            // 
            this.byCountryCode.AutoSize = true;
            this.byCountryCode.Location = new System.Drawing.Point(22, 73);
            this.byCountryCode.Name = "byCountryCode";
            this.byCountryCode.Size = new System.Drawing.Size(85, 13);
            this.byCountryCode.TabIndex = 5;
            this.byCountryCode.Text = "by Country Code";
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
            // bySource
            // 
            this.bySource.AutoSize = true;
            this.bySource.Location = new System.Drawing.Point(22, 163);
            this.bySource.Name = "bySource";
            this.bySource.Size = new System.Drawing.Size(55, 13);
            this.bySource.TabIndex = 6;
            this.bySource.Text = "by Source";
            // 
            // countryCode
            // 
            this.countryCode.Location = new System.Drawing.Point(118, 70);
            this.countryCode.Name = "countryCode";
            this.countryCode.Size = new System.Drawing.Size(85, 20);
            this.countryCode.TabIndex = 7;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(118, 104);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(85, 20);
            this.category.TabIndex = 7;
            // 
            // source
            // 
            this.source.FormattingEnabled = true;
            this.source.Location = new System.Drawing.Point(118, 160);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(85, 21);
            this.source.TabIndex = 8;
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(25, 141);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(178, 2);
            this.divider.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "News";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListBox newsList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox countryCode;
        private System.Windows.Forms.Label bySource;
        private System.Windows.Forms.Label byCategory;
        private System.Windows.Forms.Label byCountryCode;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label divider;
    }
}

