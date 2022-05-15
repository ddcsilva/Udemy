using ApiArquiteturaDDD.Domain.Interfaces.Services.User;
using ApiArquiteturaDDD.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ApiArquiteturaDDD.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
        }
    }
}
