using System;
using System.Collections;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace KURSA_DARBS_PROGII.Scripts
{
    internal class Functions
    {
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
                var linkCol = new DataGridViewLinkColumn();

                //konvertē uz stundām un minūtēm
                row.HeaderCell.Value = dTime.ToString(dTime.Month + "." + dTime.Day + " HH:mm");

                row.Cells[0].Value = data.Articles[i].Source.Name;

                row.Cells[1].Value = data.Articles[i].Url;
                


                row.Cells[2].Value = data.Articles[i].Author;
                row.Cells[3].Value = data.Articles[i].Title;
                
                gridView.Rows.Add(row);

            }
         
        }

        private static ArrayList NewsList()
        {
            var newsList = new ArrayList();




            return newsList;
        }



    }

}
