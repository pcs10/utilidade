using static System.Runtime.InteropServices.JavaScript.JSType;
using Utilidades.API.Features.BrasilAPI.Dtos;
using AutoMapper;
using Utilidades.API.Features.BrasilAPI.Models;

namespace Utilidades.API.Features.BrasilAPI.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();

        }
    }
}
