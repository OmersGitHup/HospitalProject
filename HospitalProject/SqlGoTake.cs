using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject
{
    internal class SqlGoTake
    {
        public SqlConnection Connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-6JPMHUC\\SQLSERVERFIRST;Initial Catalog=HospitalProject;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
