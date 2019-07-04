using Models.AbstractClasses;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Book : LibResource, IPaged
    {
        public int Pages { get; set; }
        public int FirstPage { get; set; }
        public List<Chapter> Chapters { get; set; }

        public string Publishment { get; set; }
        public int Edition { get; set; }
    }
}
