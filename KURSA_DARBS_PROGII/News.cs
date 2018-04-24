using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
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

        private void newsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = newsList.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;

            //noradaa url , city code un apiKey
            var url = "https://newsapi.org/v2/top-headlines?country="
                      + countryCode.Text + "&apiKey=6b1ad7c441364a58b95573ee86ed9991";

            //izmanto `encoding` savadak simboli nevus pareizi, iznēmot `us` (`ascii` laikam default)
            var json = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(url);
            var data = JsonConvert.DeserializeObject<NewsModel>(json);

            //atvar rakstu ar attiecīgo indexu
            Process.Start(data.Articles[index].Url);
        }
    }
}
