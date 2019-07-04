using Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class Chapter : ITitled, IPaged, IOrdered
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public int Pages { get; set ; }
        public int FirstPage { get; set; }

        public List<Chapter> SubChapters { get; set; }
    }
}