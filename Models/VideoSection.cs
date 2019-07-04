using Models.AbstractClasses;
using Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class VideoSection : AbstractVideo, ITitled, IOrdered
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }

        public List<VideoSection> Sections { get; set; }
        public List<VideoFragment> Fragments { get; set; }
    }
}