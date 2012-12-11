namespace Nancy.ViewEngines.Razor
{
    using System.Globalization;

    public interface ILocationlisation
    {
        CultureInfo CurrentCulture { get; set; }
        string Localise(string key);
    }
}