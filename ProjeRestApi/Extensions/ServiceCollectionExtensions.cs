using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjesiPosData.Abstract;
using WebProjesiPosData.Concrate.EntityFramework;
using WebProjesiWebServices.Abstract;
using WebProjesiWebServices.Concrete;

namespace ProjeRestApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPlacesService, WebProjesiWebServices.Concrete.PlacesService>();
            services.AddScoped<IPlaceRepository, PlaceRepository>();
            services.AddScoped<IGiderGrubu,GiderGrubuService>();
            services.AddScoped<IGiderGrubuRepository, GiderGrubuRepository>();
        
           


            return services;
        }
    }
}
