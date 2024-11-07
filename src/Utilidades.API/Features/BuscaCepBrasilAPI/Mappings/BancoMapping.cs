using static System.Runtime.InteropServices.JavaScript.JSType;
using Utilidades.API.Features.BuscaCepBrasilAPI.Dtos;
using AutoMapper;
using Utilidades.API.Features.BuscaCepBrasilAPI.Models;

namespace Utilidades.API.Features.BuscaCepBrasilAPI.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }


    }
}
