using BlogApp.DAO.Interfaces;
using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BlogApp.DAO.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected DbSet<T> _dbSet { get; set; }
        protected DbContext _blogAppContext;

        public GenericRepository(DbContext blogAppContext)
        {
            _blogAppContext = blogAppContext;
            _dbSet = _blogAppContext.Set<T>();
        }

        public virtual IList<T> FindAll()
        {
            return _dbSet.ToList();
        }

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T obj)
        {
            _blogAppContext.Entry(obj).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            _blogAppContext.SaveChanges();
        }

        public IList<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IList<T> query = _dbSet.Where(predicate).ToList();
            return query;
        }

        public IList<T> FindByIds(int[] id)
        {
            throw new NotImplementedException();
        }

        public virtual T Create(T obj)
        {
            return _dbSet.Add(obj);
        }

        public virtual T Delete(T obj)
        {
            return _dbSet.Remove(obj);
        }
    }
}
