using System.Dynamic;
using System.Net;

namespace Utilidades.API.Features.BuscaCepBrasilAPI.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErroRetorno { get; set; } //ExpandoObject representa um objeto dinamico
    }
}
