using ApiArquiteturaDDD.Domain.Entities;
using ApiArquiteturaDDD.Domain.Models;
using AutoMapper;

namespace ApiArquiteturaDDD.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserModel, UserEntity>().ReverseMap();
        }
    }
}
