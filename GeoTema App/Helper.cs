using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTema_App
{
    public static class Helper
    {
        public static string CnnVal(string AdministratorCS)
        {
            return ConfigurationManager.ConnectionStrings[AdministratorCS].ConnectionString;
        }
        public static string CnnVal1(string SuperbrugerCS)
        {
            return ConfigurationManager.ConnectionStrings[SuperbrugerCS].ConnectionString;
        }
        public static string CnnVal2(string StandardbrugerCS)
        {
            return ConfigurationManager.ConnectionStrings[StandardbrugerCS].ConnectionString;
        }
    }
}
