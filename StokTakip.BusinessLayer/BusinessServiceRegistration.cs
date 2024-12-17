using Microsoft.Extensions.DependencyInjection;
using StokTakip.BusinessLayer.Abstract;
using StokTakip.BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IProcessesService, ProcessesManager>();
            services.AddScoped<IProcessTypeService, ProcessTypeManager>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
