using Models.AbstractClasses;
using Models.Interfaces;
using System;

namespace Models
{
    [Serializable]
    public class VideoFragment: AbstractVideo, ITitled, IOrdered
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public string PathToFile { get; set; }
    }
}