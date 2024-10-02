namespace BlazorDD.Models;

public class CitiesRepository
{
    public static List<string> Cities = new List<string>()
    {
        "dhaka",
        "CTG",
        "RAJ",
        "BARI",
        "MYN",
        "CUM"
    };
    public static List<string> GetCities() => Cities;
}
