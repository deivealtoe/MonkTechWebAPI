using AutoMapper;
using MonkTechWebAPI.Models;
using MonkTechWebAPI.Models.Dto.Agenda;
using MonkTechWebAPI.Models.Dto.Endereco;
using MonkTechWebAPI.Models.Dto.Salao;
using MonkTechWebAPI.Models.Dto.Usuario;

namespace MonkTechWebAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Salao, CreateSalaoDto>().ReverseMap();
            CreateMap<Salao, GetSalaoDto>().ReverseMap();
            CreateMap<Salao, GetSalaoDetailsDto>().ReverseMap();
            CreateMap<Salao, GetSalaoAgendasDto>().ReverseMap();

            CreateMap<Endereco, GetEnderecoDto>().ReverseMap();
            CreateMap<Endereco, CreateSalaoDto>().ReverseMap();
            
            CreateMap<Agenda, GetAgendaDto>().ReverseMap();
            CreateMap<Agenda, CreateAgendaDto>().ReverseMap();
            CreateMap<Agenda, GetAgendaDetailsDto>().ReverseMap();

            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Usuario, CreateSalaoDto>().ReverseMap();
            CreateMap<UsuarioDto, CreateSalaoDto>().ReverseMap();
        }
    }
}
