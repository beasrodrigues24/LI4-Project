using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;

namespace Geres4U.Data
{
    public class DataAccess : IDataAccess
    {
        //private readonly IConfiguration _config;

        public string ConnectionString { get; set; } = "server=localhost;user=geres4u;database=geres4udb;password=Geres4U1234;port=3306";

        public DataAccess() { }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            //try
            //{
                using (IDbConnection connection = new MySqlConnection(ConnectionString))
                {
                    await connection.ExecuteAsync(sql, parameters);
                }
            //}
            //catch (Exception ignored) { }

        }
    }
}
