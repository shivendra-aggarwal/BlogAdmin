using AutoMapper;
using BlogApp.Model.TestData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BlogApp.Admin.ViewModels
{
    public class TestDataViewModel : AbstractViewModel<Table, TestDataViewModel>
    {
        #region Properties

        [DisplayName("Module Names")]
        public string Name { get; set; }

        [DisplayName("No of Entries")]
        public string TextBoxControl
        {
            get
            {
                return string.Format(@"<input type='text' class='form-control' name={0} />", Name);
            }
            private set
            {
            }
        }

        #endregion

        #region Methods

        new public static IEnumerable<TestDataViewModel> GetListOfViewModel(Table[] sources)
        {
            IMapper mapper = GetMapper();

            IEnumerable<TestDataViewModel> destinations = mapper.Map<Table[], IEnumerable<TestDataViewModel>>(sources);

            return destinations;
        }

        new protected static IMapper GetMapper()
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<Table, TestDataViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.TableName));
            });

            return mapperConfiguration.CreateMapper();
        }

        #endregion
    }
}