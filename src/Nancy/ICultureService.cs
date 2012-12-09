using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Nancy
{
    public interface ICultureService
    {
        CultureInfo DetermineCurrentCulture(NancyContext context);
        CultureInfo CurrentCulture { get; set; }
    }
}
