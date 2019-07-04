using Models.AbstractClasses;
using System;

namespace Models
{
    [Serializable]
    public class InternetResource: LibResource
    {
        public string MainLink { get; set; }
    }
}
