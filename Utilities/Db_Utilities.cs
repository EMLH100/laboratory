//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.CodeDom;
//using System.Net.NetworkInformation;

using System.Data.SqlClient;
using System.IO;

namespace laboratory.Utilities
{
    internal class Db_Utilities
    {
        private static readonly string _DATABASE_FILE_NAME = "lab_db.mdf";
        private static readonly string _EXECUTION_FOLDER =
            Path.GetFullPath(
                Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            )
        ;
        private static readonly string _DATABASE_FILE_FULL_PATH =
            //_EXECUTION_FOLDER +Path.DirectorySeparatorChar+ _DATABASE_FILE_NAME;
            _EXECUTION_FOLDER +
            Path.DirectorySeparatorChar + ".." +
            Path.DirectorySeparatorChar + ".." +
            Path.DirectorySeparatorChar
            + _DATABASE_FILE_NAME
        ; /// for bin/debug


        /* cree class TConnection ???
        public Db_Utilities(TConnection arg )
        {

        }
        */

public static SqlConnection GetDefaultConnection() // ??? pass as arg _DATABASE_FILE_FULL_PATH
        {
            // - method 1 -
            string connectionString =       // literal
                $"Server=.\\SQL2019EXPRESS; "
                + $"Integrated_security=true; "
                + $"AttachDbFilename={_DATABASE_FILE_FULL_PATH}; "
                + $"User Instance=true;"
            ;

            /*
            // - method 2 -
            Dictionary<string, string> connStringKeyValuePairs = new Dictionary<string, string>();
            connStringKeyValuePairs.Add("Server", ".\\SQL2019EXPRESS");
            connStringKeyValuePairs.Add("Integrated_security", "true");
            connStringKeyValuePairs.Add("AttachDbFilename", _DATABASE_FILE_FULL_PATH);
            connStringKeyValuePairs.Add("User Instance", "true");
            string connectionString = "";
            foreach (KeyValuePair<string, string> pair in connStringKeyValuePairs)
            {
                connectionString += pair.Key + "=" + pair.Value + ";";
            }
            */

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
