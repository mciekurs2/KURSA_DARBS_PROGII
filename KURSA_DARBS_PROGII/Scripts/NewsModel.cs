using System;
using System.Collections.Generic;

namespace KURSA_DARBS_PROGII.Scripts
{
    public class NewsModel
    {
        public string Status { get; set; }
        public long TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }

    public class Article
    {
        public Source Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTimeOffset PublishedAt { get; set; }
    }

    public class Source
    {
        public object Id { get; set; }
        public string Name { get; set; }
    }
}
