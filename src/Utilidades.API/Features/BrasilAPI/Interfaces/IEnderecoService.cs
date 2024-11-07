using Utilidades.API.Features.BrasilAPI.Dtos;

namespace Utilidades.API.Features.BrasilAPI.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
