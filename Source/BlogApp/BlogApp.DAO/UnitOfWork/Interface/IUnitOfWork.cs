using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.UnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
