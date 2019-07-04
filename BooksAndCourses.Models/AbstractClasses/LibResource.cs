using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models.AbstractClasses
{
    [Serializable]
    [XmlInclude(typeof(Book))]
    [XmlInclude(typeof(VideoCourse))]
    [XmlInclude(typeof(InternetResource))]
    public abstract class LibResource : ITitled
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<string> Themes { get; set; }
        public List<Link> Links { get; set; }

        public string[] Authors { get; set; }
        public int Year { get; set; }

        public string PathToCover { get; set; }
        public string PathToDescription { get; set; }

        public string FindType()
        {
            string type = string.Empty;
            switch(this)
            {
                case Book book: type = "Книга"; break;
                case VideoCourse video: type = "Видео"; break;
                case InternetResource internetResource: type = "Сайт"; break;
            }
            return type;
        }

        public string FindAuthor()
        {
            string author = string.Empty;
            if (Authors != null && Authors.Length > 0)
            {
                switch (this.Authors.Length)
                {
                    case 1:
                        author = Authors[0];
                        break;
                    case int n when n > 1:
                        author = Authors[0] + " и др.";
                        break;
                }
            }

            return author;
        }
    }
}
