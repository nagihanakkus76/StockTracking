using Microsoft.Extensions.DependencyInjection;
using StokTakip.DataAccessLayer.Abstract;
using StokTakip.DataAccessLayer.EntityFramework;
using StokTakip.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDal, UserRepository>();
            services.AddScoped<IProductDal, ProductRepository>();
            services.AddScoped<IProcessesDal, ProcessesRepository>();
            services.AddScoped<IProcessTypeDal, ProcessTypeRepository>();
            services.AddDbContext<StockTrackerContext>();
            return services;
        }
    }
}
