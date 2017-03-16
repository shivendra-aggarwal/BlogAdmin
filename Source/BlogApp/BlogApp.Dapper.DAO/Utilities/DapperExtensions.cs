using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Dapper.DAO.Utilities
{
    internal static class DapperExtensions
    {
        public static TEntity Insert<TEntity>(this IDbConnection con,string tableName, dynamic param)
        {
            IEnumerable<TEntity> result = SqlMapper.Query<TEntity>(con, DynamicQuery.GetInsertQuery(tableName, param), param);
            return result.First();
        }
    }
}
