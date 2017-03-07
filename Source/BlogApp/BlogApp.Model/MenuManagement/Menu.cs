using BlogApp.Model.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model.MenuManagement
{
    public class Menu : BaseEntity
    {
        public string MenuName { get; set; }

        public string MenuTitle { get; set; }

        public int? ParentId { get; set; }

        public int MenuOrder { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        [NotMapped]
        public List<Menu> ChildMenus { get; set; }
    }
}
