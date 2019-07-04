using Models.AbstractClasses;
using Models.Interfaces;
using Models.Utils;
using System;
using System.Collections.Generic;

namespace Models
{
    [Serializable]
    public class VideoCourse : LibResource, IVideo
    {
        #region AbstractVideo class realization
        public int Length { get; set; }

        [NonSerialized]
        private HoursMinutesSeconds _durationInHms;
        public HoursMinutesSeconds DurationInHms 
        {
            get 
            {
                _durationInHms = new HoursMinutesSeconds(Length);
                return _durationInHms;
            }
        }
        #endregion

        public List<VideoSection> Sections { get; set; }
    }
}
