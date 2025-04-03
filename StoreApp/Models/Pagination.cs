namespace StoreApp.Models;

public class Pagination
{
    public int TotalItem { get; set; }
    public int ItemsPerPage { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPage => (int)Math.Ceiling((decimal)TotalItem / ItemsPerPage);
}