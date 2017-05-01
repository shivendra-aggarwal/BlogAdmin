using BlogApp.Business.Interfaces;
using BlogApp.DAO.Interfaces;
using BlogApp.DAO.UnitOfWork.Interface;
using BlogApp.Model.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services
{
    public class TestDataService : GenericService<Table>, ITestDataService
    {
        IUnitOfWork _unitOfWork;
        ITestDataRepository _repository;

        public TestDataService(IUnitOfWork unitOfWork, ITestDataRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public IList<Table> GetAllSystemTables()
        {
            return _repository.FindAllSystemTables();
        }
    }
}
