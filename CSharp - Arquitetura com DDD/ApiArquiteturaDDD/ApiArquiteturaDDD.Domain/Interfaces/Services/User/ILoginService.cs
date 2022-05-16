using ApiArquiteturaDDD.Domain.Dtos;
using System.Threading.Tasks;

namespace ApiArquiteturaDDD.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
