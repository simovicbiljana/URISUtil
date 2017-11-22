using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace URISUtil.DataAccess
{
    public static class DBFunctions
    {
        private static List<string> ServiceFilters { get; set; }

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ADOConnection"].ConnectionString;
            }
        }
        //Test
        public static void AddParameter(this SqlCommand cmdToFill, string paramName, SqlDbType paramType, object param)
        {
            cmdToFill.Parameters.Add(paramName, paramType);
            if (param != null)
                cmdToFill.Parameters[paramName].Value = param;
            else
                cmdToFill.Parameters[paramName].Value = DBNull.Value;
        }
    }
}