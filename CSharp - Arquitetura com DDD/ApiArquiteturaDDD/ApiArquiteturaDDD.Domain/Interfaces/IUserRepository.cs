using ApiArquiteturaDDD.Domain.Entities;
using System.Threading.Tasks;

namespace ApiArquiteturaDDD.Domain.Interfaces
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string email);
    }
}
