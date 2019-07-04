using Models.Utils;

namespace Models.Interfaces
{
    public interface IVideo
    {
        int Length { get; set; }
        HoursMinutesSeconds DurationInHms { get; }
    }
}
