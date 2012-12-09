using System.Globalization;
using System.Threading;

namespace Nancy
{
    public class DefaultCultureService : ICultureService
    {

        public DefaultCultureService()
        {
        }

        public CultureInfo CurrentCulture { get; set; }

        public CultureInfo DetermineCurrentCulture(NancyContext context)
        {
            //if (user != null && user.Profile.Culture != null)
            //{
            //    return user.Profile.Culture;
            //}

            //if (context.Request.Session["CurrentCulutre"] != null)
            //{
            //    CurrentCulture = (CultureInfo) context.Request.Session["CurrentCulture"];
            //    return (CultureInfo)context.Request.Session["CurrentCulture"];
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
            CurrentCulture = Thread.CurrentThread.CurrentCulture;
            return Thread.CurrentThread.CurrentCulture;
        }
    }
}