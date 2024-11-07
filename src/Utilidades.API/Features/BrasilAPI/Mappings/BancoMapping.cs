using static System.Runtime.InteropServices.JavaScript.JSType;
using Utilidades.API.Features.BrasilAPI.Dtos;
using AutoMapper;
using Utilidades.API.Features.BrasilAPI.Models;

namespace Utilidades.API.Features.BrasilAPI.Mappings
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
