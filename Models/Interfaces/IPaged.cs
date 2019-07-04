namespace Models.Interfaces
{
    public interface IPaged
    {
        int Pages { get; set; }
        int FirstPage { get; set; }
    }
}
