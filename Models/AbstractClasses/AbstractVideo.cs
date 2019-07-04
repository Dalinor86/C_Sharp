using Models.Interfaces;
using Models.Utils;
using System;

namespace Models.AbstractClasses
{
    [Serializable]
    public abstract class AbstractVideo : IVideo
    {
        public int Length { get; set; }

        [NonSerialized]
        private HoursMinutesSeconds _durationInHms;
        public HoursMinutesSeconds DurationInHms {
            get {
                _durationInHms = new HoursMinutesSeconds(Length);
                return _durationInHms;
            }
        }
    }
}
