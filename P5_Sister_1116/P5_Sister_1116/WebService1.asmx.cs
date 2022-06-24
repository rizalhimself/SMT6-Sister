using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace P5_Sister_1116
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double CelciusToReamur(int C)
        {
            return (0.8) * C;
        }

        [WebMethod]
        public double CelciusToFahrenheit(int C)
        {
            return (1.8) * C + 32;
        }

        [WebMethod]
        public int CelciusToKelvin(int C)
        {
            return C + 273;
        }
    }
}
