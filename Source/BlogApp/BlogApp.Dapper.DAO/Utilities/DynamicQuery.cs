using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Dapper.DAO.Utilities
{
    internal sealed class DynamicQuery
    {
        public static string GetInsertQuery(string tableName, dynamic obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            string[] columns = props.Select(p => p.Name).Where(p => !string.Equals(p, "Identifier")).ToArray();
            return string.Format(@"INSERT {0}({1}) OUTPUT inserted.Identifier VALUES({2})",
                tableName,
                string.Join(",", columns),
                string.Join(",@", columns)
                );
        }
    }
}
