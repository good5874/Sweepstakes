using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Sweepstakes.DAL.Abstracts
{
    public abstract class AbstractRepository<T>
    {
        private string connection { get; set; }

        public AbstractRepository(IConfiguration configuration)
        {
            connection = configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<T> ExecuteSqlQuery(string sqlQuery)
        {
            List<T> items = new();

            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    object[] rows = new object[reader.FieldCount];
                    reader.GetValues(rows);
                    T item = (T)Activator.CreateInstance(typeof(T), rows);
                    items.Add(item);
                }

                con.Close();
            }
            return items;
        }

        public T ExecuteScalarSqlQuery(string sqlQuery)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                object[] rows = new object[reader.FieldCount];
                reader.Read();
                reader.GetValues(rows);

                con.Close();

                if (rows.Count() > 0)
                {
                    T item = (T)Activator.CreateInstance(typeof(T), rows);
                    return item;
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}
