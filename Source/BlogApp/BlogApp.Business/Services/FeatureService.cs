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
    public class FeatureService : GenericService<Feature>, IFeatureService
    {
        private IUnitOfWork _unitOfWork;
        private IFeatureRepository _repository;
        private IFeatureTypeRepository _typeRepository;

        public FeatureService(
            IUnitOfWork unitOfWork,
            IFeatureRepository repository,
            IFeatureTypeRepository typeRepository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _typeRepository = typeRepository;
        }

        public override IList<Feature> GetAll()
        {
            IList<Feature> features = base.GetAll();

            if (features.Any())
            {
                IList<FeatureType> featureTypes = _typeRepository.FindAll();

                features.ToList().ForEach(feature =>
                {
                    feature.FeatureType = featureTypes.FirstOrDefault(type => type.Identifier == feature.FeatureTypeId);
                });
            }

            return features;
        }
    }
}
