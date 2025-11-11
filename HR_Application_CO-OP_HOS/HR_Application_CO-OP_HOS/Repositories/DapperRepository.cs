using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_CO_OP_HOS.Repositories
{
    public class DapperRepository
    {
        private readonly string _connectionString;
        public DapperRepository(string connectionStrings)
        {
            _connectionString = connectionStrings;
        }

        private IDbConnection Connection => new SqlConnection(_connectionString);

        public IEnumerable<T> Query<T>(string sql, object param = null)
        {
            using (var db = Connection)
            {
                return db.Query<T>(sql, param);
            }
        }

        public T QuerySingle<T>(string sql, object param = null)
        {
            using (var db = Connection)
            {
                return db.QuerySingleOrDefault<T>(sql, param);
            }
        }

        public int Execute(string sql, object param = null)
        {
            using (var db = Connection)
            {
                return db.Execute(sql, param);
            }
        }
    }
}