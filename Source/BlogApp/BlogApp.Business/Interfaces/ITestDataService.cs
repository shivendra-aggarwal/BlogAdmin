using BlogApp.Model.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Interfaces
{
    public interface ITestDataService : IGenericService<Table>
    {
        IList<Table> GetAllSystemTables();
    }
}
