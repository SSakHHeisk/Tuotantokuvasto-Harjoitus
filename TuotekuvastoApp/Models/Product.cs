namespace TuotekuvastoApp.Models;

public class Product
{
    public string? Name {get; set;}
    public decimal Price {get; set;}
    public string? Description {get; set;}
    public string? Image {get; set;}
    public string? FormattedName => System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Name);
    public string? FormattedPrice => $"{Price:N2} €";
}
