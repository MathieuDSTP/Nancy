using System.Globalization;
using System.Threading;

namespace Nancy
{
    public class DefaultCultureService : ICultureService
    {
        private readonly NancyContext context;

        public DefaultCultureService()
        {
        //    this.context = context;
        }

        public CultureInfo GetCurrentCulture()
        {
            //if (user != null && user.Profile.Culture != null)
            //{
            //    return user.Profile.Culture;
            //}

            

            //if (session["CurrentCulture"] != null)
            //{
            //    return (CultureInfo)session["CurrentCulture"];
            //}

            //if (request.Cookies["CurrentCulture"] != null)
            //{
            //    return new CultureInfo(request.Cookies["CurrentCulture"].Value);
            //}

            //return new CultureInfo(ApplicationSettings.DefaultCulture);

            return Thread.CurrentThread.CurrentCulture;
        }
    }
}