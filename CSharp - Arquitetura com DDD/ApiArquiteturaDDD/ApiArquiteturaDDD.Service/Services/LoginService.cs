﻿using ApiArquiteturaDDD.Domain.Entities;
using ApiArquiteturaDDD.Domain.Interfaces;
using ApiArquiteturaDDD.Domain.Interfaces.Services.User;
using System.Threading.Tasks;

namespace ApiArquiteturaDDD.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;
        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> FindByLogin(UserEntity user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                return await _repository.FindByLogin(user.Email);
            }
            else
            {
                return null;
            }
        }
    }
}