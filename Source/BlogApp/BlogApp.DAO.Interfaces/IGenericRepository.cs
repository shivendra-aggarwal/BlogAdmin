using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IList<T> FindAll();

        T FindById(int id);

        IList<T> FindBy(Expression<Func<T, bool>> predicate);

        IList<T> FindByIds(int[] id);

        T Create(T obj);

        void Update(T obj);

        T Delete(T obj);

        void SaveChanges();
    }
}
