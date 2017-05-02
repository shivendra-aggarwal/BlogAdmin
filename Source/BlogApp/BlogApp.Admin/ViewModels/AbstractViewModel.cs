using AutoMapper;
using AutoMapper.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Admin.ViewModels
{
    public abstract class AbstractViewModel<TSource, TDestination>
    {
        public static IEnumerable<TDestination> GetListOfViewModel(TSource[] sources)
        {
            IMapper mapper = GetMapper();

            IEnumerable<TDestination> destinations = mapper.Map<TSource[], IEnumerable<TDestination>>(sources);

            return destinations;
        }

        public static TDestination GetViewModel(TSource source)
        {
            IMapper mapper = GetMapper();

            TDestination destination = mapper.Map<TSource, TDestination>(source);

            return destination;
        }

        protected static IMapper GetMapper()
        {
            var mapperConfiguration = new MapperConfiguration(config => {
                config.CreateMap<TSource, TDestination>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}