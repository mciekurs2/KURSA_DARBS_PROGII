using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KURSA_DARBS_PROGII.Scripts;

namespace KURSA_DARBS_PROGII
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //lai atjainotu info
            //newsDataGridView.Rows.Clear();
            //newsDataGridView.Refresh();

            //izsauc metodi
            //Scripts.Functions.GetNewsData(countryCode.Text, newsDataGridView);

            Scripts.Functions.LoadNews(newsList, countryCode.Text);

        }

        private void NewsList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 80;
        }

        private void NewsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            var listBox = sender as ListBox;
            var newsAdapter = listBox?.Items[e.Index] as NewsAdapter;

            e.DrawBackground();
            newsAdapter?.DrawDesign(e.Graphics, e.Bounds, Font, false);
        }
    }
}
