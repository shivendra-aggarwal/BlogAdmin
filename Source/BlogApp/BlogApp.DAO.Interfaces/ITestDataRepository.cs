using BlogApp.Model.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.Interfaces
{
    public interface ITestDataRepository : IGenericRepository<Table>
    {
        IList<Table> FindAllSystemTables();
    }
}
