using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Interfaces
{
    public interface IGenericService<T> : IService where T: BaseEntity
    {
        IList<T> GetAll();

        T GetById(int id);

        IList<T> GetBy(Expression<Func<T, bool>> predicate);

        IList<T> GetByIds(int[] id);

        void Create(T obj);

        void Update(T obj);

        void Delete(T obj);
        
    }
}
