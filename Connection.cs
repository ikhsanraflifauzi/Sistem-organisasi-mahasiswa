using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UAS
{
    class Connection
    {
        public static string socket = "Data Source = 127.0.0.1, 1433; " +
            "Initial Catalog = UAS; Integrated security = true";
        public static SqlConnection cone = new SqlConnection(socket);

    }
}
