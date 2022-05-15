using ApiArquiteturaDDD.Data.Context;
using ApiArquiteturaDDD.Data.Repositories;
using ApiArquiteturaDDD.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApiArquiteturaDDD.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql("Server=localhost;Port=3306;Database=CourseApiDDD;Uid=root;Pwd=root")
            );
        }
    }
}
