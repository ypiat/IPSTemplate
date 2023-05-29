namespace IPSTemplate.BusinessLibrary.StandardCollections;

public class TEGenreSC
{
    public const string Adventure = "Adventure";
    public const string Classics = "Classics";
    public const string Detective = "Detective";
    public const string Fantasy = "Fantasy";
    public const string Horror = "Horror";
    public const string Romance = "Romance";

    public static List<string> All => new()
    {
        Adventure,
        Classics,
        Detective,
        Fantasy,
        Horror,
        Romance
    };

    public static Dictionary<string, string> OrderedUserFriendlyNameMap => new Dictionary<string, string>
    {
        { Adventure, GetUserFriendlyName(Adventure) },
        { Classics, GetUserFriendlyName(Classics) },
        { Detective , GetUserFriendlyName(Detective) },
        { Fantasy , GetUserFriendlyName(Fantasy) },
        { Horror , GetUserFriendlyName(Horror) },
        { Romance , GetUserFriendlyName(Romance) },
    }.OrderBy(c => c.Value).ToDictionary(c => c.Key, c => c.Value);

    public static string GetUserFriendlyName(string value) => value switch
    {
        Adventure => "Adventure",
        Classics => "Classics",
        Detective => "Detective",
        Fantasy => "Fantasy",
        Horror => "Horror",
        Romance => "Romance",
        _ => ""
    };
}
