using ApiArquiteturaDDD.Domain.Dtos.User;
using ApiArquiteturaDDD.Domain.Models;
using AutoMapper;

namespace ApiArquiteturaDDD.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>().ReverseMap();
            //CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            //CreateMap<UserModel, UserDtoUpdate>().ReverseMap();
        }
    }
}
