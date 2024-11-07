using Utilidades.API.Features.BrasilAPI.Dtos;

namespace Utilidades.API.Features.BrasilAPI.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}
