using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        private readonly Contexto _contexto;

        public RepositorioGenerico(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task Atualizar(T entity)
        {
            try
            {
                _contexto.Set<T>().Update(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(T entity)
        {
            try
            {
                _contexto.Set<T>().Remove(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(int id)
        {
            try
            {
                var entity = await Selecionar(id);
                _contexto.Set<T>().Remove(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(string id)
        {
            try
            {
                var entity = await Selecionar(id);
                _contexto.Set<T>().Remove(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Inserir(T entity)
        {
            try
            {
                await _contexto.AddAsync(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Selecionar(int id)
        {
            try
            {
                return await _contexto.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Selecionar(string id)
        {
            try
            {
                return await _contexto.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<T>> Listar()
        {
            try
            {
                return await _contexto.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
