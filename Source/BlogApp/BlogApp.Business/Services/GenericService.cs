using BlogApp.Business.Interfaces;
using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using BlogApp.DAO.UnitOfWork.Interface;
using BlogApp.DAO.Interfaces;

namespace BlogApp.Business.Services
{
    public abstract class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private IUnitOfWork _unitOfWork;
        private IGenericRepository<T> _repository;

        public GenericService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual void Create(T obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException("obj");
            }
            _repository.Create(obj);
            _unitOfWork.Commit();
        }

        public void Delete(T obj)
        {
            if (obj == null) { throw new ArgumentNullException("obj"); }
            _repository.Delete(obj);
            _unitOfWork.Commit();
        }

        public virtual IList<T> GetAll()
        {
            return _repository.FindAll();
        }

        public IList<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return _repository.FindBy(predicate);
        }

        public T GetById(int id)
        {
            return _repository.FindById(id);
        }

        public IList<T> GetByIds(int[] id)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            if (obj == null) { throw new ArgumentNullException("obj"); }
            _repository.Update(obj);
            _unitOfWork.Commit();
        }
    }
}
