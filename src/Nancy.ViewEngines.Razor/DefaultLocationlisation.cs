using System;

namespace Nancy.ViewEngines.Razor
{
    public class DefaultLocationlisation : ILocationlisation
    {
        private readonly ICultureService cultureService;

        public DefaultLocationlisation(ICultureService cultureService)
        {
            this.cultureService = cultureService;
        }

        public string Localise(string key)
        {
            var cultureInfo = this.cultureService.CurrentCulture;

            if (cultureInfo.Name == "en-GB")
                return "Good day friend";
            else if (cultureInfo.Name == "de-DE")
                return "Guten Tag freund";
            else
                return "Howdy stranger";
        }
    }
}