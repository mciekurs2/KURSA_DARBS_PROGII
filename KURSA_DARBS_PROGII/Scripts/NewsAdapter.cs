using System.Drawing;


namespace KURSA_DARBS_PROGII.Scripts
{
    internal class NewsAdapter
    {
        public Image NewsImage;
        public string NewsTittle;
        public string NewsDescription;
        public string NewsAuthor;
        public string NewsAddedTime;

        public NewsAdapter(Image image, string tittle, string description, string author, string addedTime)
        {
            NewsImage = image;
            NewsTittle = tittle;
            NewsDescription = description;
            NewsAuthor = author;
            NewsAddedTime = addedTime;
        }

        //vispārējā forma pārējiem elementiem
        public string ContentDesign()
        {
            return NewsTittle + "\n" + NewsDescription + "\n" + "News Author: " + NewsAuthor
                   + "  Time added: " + NewsAddedTime;
        }

        public void DrawDesign(Graphics gr, Rectangle bounds, Font font, bool showNameOnly)
        {
            //uzstādā taisnūra izmērus
            var margin = (int)(bounds.Height * 0.05);
            var height = bounds.Height - 2 * margin;

            //uzstāda bildi
            var srcRect = new Rectangle(0, 0, NewsImage.Width, NewsImage.Height);
            var destRect = new Rectangle(bounds.Left + margin, bounds.Top + margin, height, height);
            gr.DrawImage(NewsImage, destRect, srcRect, GraphicsUnit.Pixel);

            //pievieno izskārtojumu pārējiem elementiem
            var textLeft = destRect.Right + margin;
            var width = bounds.Width - textLeft;
            var layoutRect = new Rectangle(textLeft, bounds.Top, width, bounds.Height);

            //piesaista ContentDesign
            using (var stringFormat = new StringFormat())
            {
                stringFormat.LineAlignment = StringAlignment.Center;
                gr.DrawString(showNameOnly ? ToString() : ContentDesign(), font, Brushes.Black,
                    layoutRect, stringFormat);
            }


        }


    }
}
