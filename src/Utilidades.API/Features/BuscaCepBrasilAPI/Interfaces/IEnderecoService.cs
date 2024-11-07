using Utilidades.API.Features.BuscaCepBrasilAPI.Dtos;

namespace Utilidades.API.Features.BuscaCepBrasilAPI.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
