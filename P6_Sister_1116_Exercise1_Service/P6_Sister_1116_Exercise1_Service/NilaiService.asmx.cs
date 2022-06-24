using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace P6_Sister_1116_Exercise1_Service
{
    /// <summary>
    /// Summary description for NilaiService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NilaiService : System.Web.Services.WebService
    {

        [WebMethod]
        public string nilai(int angka)
        {
            string nilaiAkhir = "";
            if (angka < 60)
            {
                nilaiAkhir = "Remidial";
            }
            else if (angka == 60 && angka < 69)
            {
                nilaiAkhir = "Not Bad";
            }
            else if (angka == 70 && angka < 79)
            {
                nilaiAkhir = "Good";
            }
            else if (angka > 80)
            {
                nilaiAkhir = "Exelent";
            }
            return nilaiAkhir;
        }
    }
}
