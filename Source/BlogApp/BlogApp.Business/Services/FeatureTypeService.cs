using BlogApp.Business.Interfaces;
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
    public class FeatureTypeService : GenericService<FeatureType>, IFeatureTypeService
    {
        IUnitOfWork _unitOfWork;
        IFeatureTypeRepository _repository;

        public FeatureTypeService(IUnitOfWork unitOfWork, IFeatureTypeRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
