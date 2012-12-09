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

            return "Hello Ella";
        }
    }
}