using ApiArquiteturaDDD.Domain.Dtos.User;
using ApiArquiteturaDDD.Domain.Entities;
using AutoMapper;

namespace ApiArquiteturaDDD.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();

            CreateMap<UserDtoCreateResult, UserEntity>().ReverseMap();

            CreateMap<UserDtoUpdateResult, UserEntity>().ReverseMap();
        }
    }
}
