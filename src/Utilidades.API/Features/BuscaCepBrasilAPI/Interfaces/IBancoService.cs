using Utilidades.API.Features.BuscaCepBrasilAPI.Dtos;

namespace Utilidades.API.Features.BuscaCepBrasilAPI.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}
