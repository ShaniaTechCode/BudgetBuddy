using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy
{
    public class Conecction
    {
        private string connectionString = @"Data Source=DESKTOP-M46PC6F\SQLEXPRESS;Initial Catalog=db_BudgetBuddy;Integrated Security=True;TrustServerCertificate=true;";
        private SqlConnection sqlConnection;
        public Conecction()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }
    }
}
