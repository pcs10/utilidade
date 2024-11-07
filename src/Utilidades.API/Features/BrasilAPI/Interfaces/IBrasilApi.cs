using Utilidades.API.Features.BrasilAPI.Dtos;
using Utilidades.API.Features.BrasilAPI.Models;

namespace Utilidades.API.Features.BrasilAPI.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

    }
}
