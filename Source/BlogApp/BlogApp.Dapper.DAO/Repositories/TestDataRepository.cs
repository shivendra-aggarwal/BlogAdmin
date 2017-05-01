using BlogApp.DAO.Interfaces;
using BlogApp.Model.TestData;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Dapper.DAO.Repositories
{
    public class TestDataRepository : GenericRepository<Table>, ITestDataRepository
    {
        public TestDataRepository()
            : base("sys.objects")
        {

        }

        public IList<Table> FindAllSystemTables()
        {
            IList<Table> list = null;

            using (IDbConnection con = Connection)
            {
                con.Open();
                list = con.Query<Table>(string.Format(@"SELECT 
                                                        		OBJECT_ID as Identifier, 
                                                        		NAME as TableName 
                                                        FROM 
                                                        		sys.objects 
                                                        WHERE 
                                                        		TYPE=N'U' 
                                                        		ORDER BY NAME")).ToList();
            }

            return list;
        }
    }
}
