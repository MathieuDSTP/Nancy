using System.Globalization;

namespace Nancy.ViewEngines.Razor
{
    using System;
    using Nancy.Culture;

    public class DefaultLocationlisation : ILocationlisation
    {
        public CultureInfo CurrentCulture { get; set; }

        public string Localise(string key)
        {
            if (CurrentCulture.Name == "en-GB")
                return "Good day friend";
            else if (CurrentCulture.Name == "de-DE")
                return "Guten Tag freund";
            else
                return "Howdy stranger";
        }
    }
}