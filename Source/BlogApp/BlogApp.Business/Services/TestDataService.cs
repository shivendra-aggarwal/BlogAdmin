using BlogApp.Business.Interfaces;
using BlogApp.Common.Database;
using BlogApp.DAO.Interfaces;
using BlogApp.DAO.UnitOfWork.Interface;
using Model = BlogApp.Model.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services
{
    public class TestDataService : GenericService<Model.TestData.Table>, ITestDataService
    {
        IUnitOfWork _unitOfWork;
        ITestDataRepository _repository;

        public TestDataService(IUnitOfWork unitOfWork, ITestDataRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public IList<Model.TestData.Table> GetAllSystemTables()
        {
            IList<Model.TestData.Table> tables = _repository.FindAllSystemTables();
            return tables.Where(table => !this.GetAllMasterTablesToExcludeFromImport().Contains(table.TableName)).ToList();
        }


        private IList<string> GetAllMasterTablesToExcludeFromImport()
        {
            return new List<string>()
            {
                MasterTable.FeatureType,
                MasterTable.Menu,
                MasterTable.VersionInfo
            };

        }
    }
}
