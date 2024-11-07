using static System.Runtime.InteropServices.JavaScript.JSType;
using Utilidades.API.Features.BuscaCepBrasilAPI.Dtos;
using AutoMapper;
using Utilidades.API.Features.BuscaCepBrasilAPI.Models;

namespace Utilidades.API.Features.BuscaCepBrasilAPI.Mappings
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
