﻿using AutoMapper;
using Utilidades.API.Features.BuscaCepBrasilAPI.Dtos;
using Utilidades.API.Features.BuscaCepBrasilAPI.Interfaces;

namespace Utilidades.API.Features.BuscaCepBrasilAPI.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCEP(cep);

            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}
