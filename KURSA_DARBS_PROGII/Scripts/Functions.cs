using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace KURSA_DARBS_PROGII.Scripts
{
    internal class Functions
    {
        public static bool optionCheck = true;

        public static void GetNewsData(string cityCode, DataGridView  gridView)
        {
            //noradaa url , city code un apiKey
            var url = "https://newsapi.org/v2/top-headlines?country="
                      + cityCode + "&apiKey=6b1ad7c441364a58b95573ee86ed9991";

            //izmanto `encoding` savadak simboli nevus pareizi, iznēmot `us` (`ascii` laikam default)
            var json = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(url);
            var data = JsonConvert.DeserializeObject<NewsModel>(json);

            //nodrifee izmeeru prieksh header
            gridView.RowHeadersWidth = 100;

            //iet cauri katram mainīgajam cauri json, tāpēc i < 19
            for (var i = 0; i < 19; i++)
            {
                var row = (DataGridViewRow) gridView.Rows[i].Clone();
                
                //konvrtē laika formātu
                var dTime = Convert.ToDateTime(data.Articles[i].PublishedAt.DateTime);
                //var linkCol = new DataGridViewLinkColumn();

                //konvertē uz stundām un minūtēm
                row.HeaderCell.Value = dTime.ToString(dTime.Month + "." + dTime.Day + " HH:mm");

                row.Cells[0].Value = data.Articles[i].Source.Name;

                row.Cells[1].Value = data.Articles[i].Url;
                


                row.Cells[2].Value = data.Articles[i].Author;
                row.Cells[3].Value = data.Articles[i].Title;
                
                gridView.Rows.Add(row);

            }
         
        }

        private static ArrayList NewsList(string url)
        {
            var newsList = new ArrayList();

            //izmanto `encoding` savadak simboli nevus pareizi, iznēmot `us` (`ascii` laikam default)
            var json = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(url);
            var data = JsonConvert.DeserializeObject<NewsModel>(json);

            var imageData = new WebClient();
            //MemoryStream ms;

            for (var i = 0; i < 19; i++)
            {
                byte[] getImage;
                string author;
                DateTime dTime;

                //nav pats pareizākā error ķeršana, bet dara savu dabu..
                try
                {
                    dTime = Convert.ToDateTime(data.Articles[i].PublishedAt.DateTime);
                }
                catch (ArgumentOutOfRangeException)
                {
                    //MessageBox.Show("Please eneter valid value ");
                    break;
                }

                var imageUrl = data.Articles[i]?.UrlToImage;
                var title = data.Articles[i]?.Title;
                var description = data.Articles[i]?.Description;

                //nomaina uz `unknown`, ja autors nav zināms
                try { author = data.Articles[i]?.Author; }
                catch (ArgumentNullException) { author = "unknown"; }

                var addedTime = dTime.ToString(dTime.Month + "." + dTime.Day + " HH:mm");

                //nomaina uz default bildi, ja bidle nav pieejama
                try
                {
                    getImage = imageData.DownloadData(imageUrl);
                }
                catch (ArgumentNullException)
                {
                    getImage = imageData.DownloadData(
                        "https://vignette.wikia.nocookie.net/simpsons/images/6/60/No_Image_Available.png/revision/latest?cb=20170219125728");
                }
                catch (WebException)
                {
                    getImage = imageData.DownloadData(
                        "https://vignette.wikia.nocookie.net/simpsons/images/6/60/No_Image_Available.png/revision/latest?cb=20170219125728");
                }

                var ms = new MemoryStream(getImage);

                //pievieno informaciju pie ListBox
                var news = new NewsAdapter(Image.FromStream(ms), title, description, author, addedTime);
                newsList.Add(news);
            }
            return newsList;
        }

        public static void LoadNews(ListBox listBox, string url)
        {
            listBox.DataSource = null;
            listBox.DataSource = NewsList(url);
        }
    }

}
