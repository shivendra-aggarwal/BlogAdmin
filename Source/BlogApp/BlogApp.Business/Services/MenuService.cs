using BlogApp.Business.Interfaces;
using BlogApp.DAO.Interfaces;
using BlogApp.DAO.UnitOfWork.Interface;
using BlogApp.Model.FeatureManagement;
using BlogApp.Model.MenuManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services
{
    public class MenuService : GenericService<Menu>, IMenuService
    {
        IUnitOfWork _unitOfWork;
        IMenuRepository _repository;

        public MenuService(IUnitOfWork unitOfWork, IMenuRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public override IList<Menu> GetAll()
        {
            List<Menu> menus = base.GetAll().ToList();

            menus.Where(menu => menu.ParentId == null).OrderBy(menu => menu.MenuOrder).ToList().ForEach(menu =>
                {
                    List<Menu> childMenus = menus.Where(child => child.ParentId == menu.Identifier).ToList();
                    if (childMenus != null && childMenus.Count > 0)
                    {
                        menu.ChildMenus = new List<Menu>();
                        menu.ChildMenus.AddRange(childMenus);
                    }
                });

            return menus.Where(menu => menu.ParentId == null).ToList();
        }
    }
}
