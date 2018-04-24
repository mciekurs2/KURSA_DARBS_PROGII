using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KURSA_DARBS_PROGII.Scripts;
using Newtonsoft.Json;

namespace KURSA_DARBS_PROGII
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            countryCodeList.DataSource = Enum.GetValues(typeof(CountryList));
            categoryList.DataSource = Enum.GetValues(typeof(CategoryList));
            sourceList.DataSource = Enum.GetValues(typeof(SourceList));

        }


        //glabājas json string vērtības, kuras tiek padotas uz DoubleClick eventu
        public static NewsModel DataCategory;
        public static NewsModel DataCountry;
        public static NewsModel DataSource;

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //lai atjainotu info
            //newsDataGridView.Rows.Clear();
            //newsDataGridView.Refresh();

            //izsauc metodi
            //Scripts.Functions.GetNewsData(countryCode.Text, newsDataGridView);
            
            //newsList.Enabled = false;

            if (!string.IsNullOrWhiteSpace(countryCode.Text))
            {
                var url = "https://newsapi.org/v2/top-headlines?country="
                          + countryCode.Text + "&apiKey=6b1ad7c441364a58b95573ee86ed9991";
                var json = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(url);
                DataCountry = JsonConvert.DeserializeObject<NewsModel>(json);


                Functions.LoadNews(newsList, url);
            }

            if (!string.IsNullOrWhiteSpace(countryCode.Text) && !string.IsNullOrWhiteSpace(category.Text))
            {
                var url = "https://newsapi.org/v2/top-headlines?country="
                          + countryCode.Text + "&category=" + category.Text + "&apiKey=6b1ad7c441364a58b95573ee86ed9991";
                var json = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(url);
                DataCategory = JsonConvert.DeserializeObject<NewsModel>(json);

                Functions.LoadNews(newsList, url);
            }

            if (!string.IsNullOrWhiteSpace(source.Text))
            {
                var url = "https://newsapi.org/v2/top-headlines?sources="
                          + source.Text + "&apiKey=6b1ad7c441364a58b95573ee86ed9991";
                var json = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(url);
                DataCountry = JsonConvert.DeserializeObject<NewsModel>(json);


                Functions.LoadNews(newsList, url);
            }

            newsList.Enabled = true;    

        }

        private void NewsList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 80;
        }

        private void NewsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            var listBox = sender as ListBox;

            NewsAdapter newsAdapter = null;

            try { newsAdapter = listBox?.Items[e.Index] as NewsAdapter; }
            catch (ArgumentOutOfRangeException) { }

            //var newsAdapter = listBox?.Items[e.Index] as NewsAdapter;

            e.DrawBackground();
            newsAdapter?.DrawDesign(e.Graphics, e.Bounds, Font, false);
        }

        private void newsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = newsList.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;

            if (!string.IsNullOrWhiteSpace(countryCode.Text) && string.IsNullOrWhiteSpace(category.Text))
            {
                Process.Start(DataCountry.Articles[index].Url);
            }

            if (!string.IsNullOrWhiteSpace(countryCode.Text) && !string.IsNullOrWhiteSpace(category.Text))
            {
                Process.Start(DataCategory.Articles[index].Url);
            }

                
            
        }

        private void countryCode_TextChanged(object sender, EventArgs e)
        {
            //parbauda vai textBox ir empty (nepieciešams lai nepieļautu kļūmes)
            category.Enabled = !string.IsNullOrWhiteSpace(countryCode.Text);
            searchButton.Enabled = !string.IsNullOrWhiteSpace(countryCode.Text) || !string.IsNullOrWhiteSpace(source.Text);
           
            
            
                //status.Text = "Searching by..";
            


            /* if (string.IsNullOrWhiteSpace(countryCode.Text))
             {
                 category.Enabled = true;
             }*/

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            category.Enabled = false;
            searchButton.Enabled = false;
            newsList.Enabled = false;
        }

        private enum SourceList
        {
            cnn = 0,
            espn = 1, 
            ign = 2,
            abc_news = 3,
            bbc_news = 4,
            fox_news = 5
        }

        private enum CountryList
        {
            lv = 0,
            lt = 1,
            ru = 2,
            hu = 3,
            fr = 4,
            gr = 5
        }

        private enum CategoryList
        {
            entertainment = 0,
            business = 1,
            health = 2,
            science = 3,
            sports = 4,
            technology = 5
        }

        private void source_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = !string.IsNullOrWhiteSpace(source.Text) || !string.IsNullOrWhiteSpace(countryCode.Text);
        }
    }
}
