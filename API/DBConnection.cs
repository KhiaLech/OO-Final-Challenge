using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string ConnString = @"Server =civapi.database.windows.net;
                                  Database=civapi;User Id=civ_user; Password=Monday1330";
            return new SqlConnection(ConnString);
        }
    }
}