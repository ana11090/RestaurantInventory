using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DataAccessLayer
{
    static internal class ConnectionHelper
    {
        internal static string GetConnectionStringSettings
        {
            get{
                 return ConfigurationManager
                              .ConnectionStrings["RestaurantConnectionString"].ConnectionString;
            }
           
        }
    }
}
