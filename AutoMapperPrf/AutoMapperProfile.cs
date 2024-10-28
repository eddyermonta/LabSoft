using AutoMapper;
using LabSoft.Data;
using LabSoft.DTOs;

namespace LabSoft.AutoMapperPrf
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClienteRequestDTO, Cliente>();
            CreateMap<Cliente, ClienteResponseDTO>();
            CreateMap<Direccion, DireccionResponseDTO>();
            CreateMap<Preferencia, PreferenciaResponseDTO>();
        }
    }
}