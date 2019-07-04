using Models.Interfaces;
using System;

namespace Models
{
    [Serializable]
    public class Link: ITitled
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
