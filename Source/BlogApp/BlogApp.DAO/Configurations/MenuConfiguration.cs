using BlogApp.Common.Database;
using BlogApp.Model.MenuManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAO.Configurations
{
    public class MenuConfiguration : EntityTypeConfiguration<Menu>
    {
        public MenuConfiguration()
        {
            ToTable(Table.Menu);

            HasKey(t => t.Identifier);

            Ignore(t => t.ChildMenus);
        }
    }
}
