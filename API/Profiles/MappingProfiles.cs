using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Categoriaper, CategoriaPerDto>().ReverseMap();
        CreateMap<Ciudad, CiudadDto>().ReverseMap();
        CreateMap<Contactoper, ContactoPerDto>().ReverseMap();
        CreateMap<Contrato, ContratoDto>().ReverseMap();
        CreateMap<Departamento, DepartamentoDto>().ReverseMap();
        CreateMap<Dirpersona, DirPersonaDto>().ReverseMap();
        CreateMap<Estado, EstadoDto>().ReverseMap();
        CreateMap<Pais, PaisDto>().ReverseMap();
        CreateMap<Persona, PersonaDto>().ReverseMap();
        CreateMap<Programacion, ProgramacionDto>().ReverseMap();
        CreateMap<Tipocontacto, TipoContactoDto>().ReverseMap();
        CreateMap<Tipodireccion, TipoDireccionDto>().ReverseMap();
        CreateMap<Tipopersona, TipoPersonaDto>().ReverseMap();
        CreateMap<Turno, TurnoDto>().ReverseMap();
    }
}