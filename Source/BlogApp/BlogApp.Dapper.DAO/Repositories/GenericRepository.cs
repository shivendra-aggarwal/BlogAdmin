using BlogApp.DAO.Interfaces;
using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BlogApp.Dapper.DAO.Utilities;
using Dapper;

namespace BlogApp.Dapper.DAO.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly string _tableName;

        internal IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["BlogContext"].ConnectionString);
            }
        }

        public GenericRepository(string tableName)
        {
            _tableName = tableName;
        }

        public TEntity Create(TEntity obj)
        {
            using (IDbConnection cn = Connection)
            {
                obj = cn.Insert<TEntity>(_tableName, obj);
            }

            return obj;
        }

        public TEntity Delete(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> FindByIds(int[] id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
