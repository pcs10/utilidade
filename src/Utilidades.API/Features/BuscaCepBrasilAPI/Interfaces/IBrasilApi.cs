using Utilidades.API.Features.BuscaCepBrasilAPI.Dtos;
using Utilidades.API.Features.BuscaCepBrasilAPI.Models;

namespace Utilidades.API.Features.BuscaCepBrasilAPI.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

    }
}
