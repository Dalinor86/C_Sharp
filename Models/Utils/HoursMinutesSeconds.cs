namespace Models.Utils
{
    public struct HoursMinutesSeconds
    {
        public HoursMinutesSeconds(int lengthInSeconds)
        {
            Hours = lengthInSeconds / 3600;
            Minutes = lengthInSeconds % 3600 / 60;
            Seconds = lengthInSeconds % 60;
        }

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            return $"{Hours}:{Minutes:D2}:{Seconds:D2}";
        }
    }
}
