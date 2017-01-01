using BlogApp.DAO.Interfaces;
using BlogApp.DAO.UnitOfWork.Interface;
using BlogApp.Model.FeatureManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services
{
    public class FeatureService : GenericService<Feature>
    {
        private IUnitOfWork _unitOfWork;
        private IFeatureRepository _repository;

        public FeatureService(IUnitOfWork unitOfWork, IFeatureRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
