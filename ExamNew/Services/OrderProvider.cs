using ExamNew.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamNew.Services
{
    public class OrderProvider
    {
        private SqlConnection _sqlConnection;
        public OrderProvider(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public List<Order> GetAll()
        {
            List<Order> result = new List<Order>();
            try
            {
                _sqlConnection.Open();
                var cmd = new SqlCommand(
                    @"SELECT TOP (1000) [Id],
                                        [OrderId],
                                        [PackageId],
                                        [Quantity],
                                        [Price]
                      FROM[newExam].[dbo].[Orders]", _sqlConnection);
                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Order order = new Order
                        {
                            Id = reader.GetInt32(0),
                            OrderId = reader.GetInt32(1),
                            PackageId = reader.GetInt32(2),
                            Price = reader.GetDouble(3)
                        };
                        result.Add(order);
                    }
                }
            }
            finally
            {
                _sqlConnection.Close();
            }
            return result;
        }
    }
}
