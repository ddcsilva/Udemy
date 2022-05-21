using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        Task<IEnumerable<T>> Listar();
        Task<T> Selecionar(int id);
        Task<T> Selecionar(string id);
        Task Inserir(T entity);
        Task Atualizar(T entity);
        Task Excluir(T entity);
        Task Excluir(int id);
        Task Excluir(string id);
    }
}
