using ApiArquiteturaDDD.Domain.Entities;
using System.Threading.Tasks;

namespace ApiArquiteturaDDD.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(UserEntity user);
    }
}
