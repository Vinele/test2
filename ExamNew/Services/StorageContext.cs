using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNew.Services
{
    public class StorageContext
    {
        public OrderProvider OrderProvider { get; }
        public StorageContext()
        {
            var connection = CreateConnection();
            OrderProvider = new OrderProvider();
        }
        private SqlConnection CreateConnection()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "WORKPC";
            builder.InitialCatalog = "newExam";
            builder.UserID = "";
            builder.Password = "";
            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
        }

    }
}
