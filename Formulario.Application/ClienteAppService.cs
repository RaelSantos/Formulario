using Formulario.Application.Interface;
using Formulario.Domain.Entities;
using Formulario.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Formulario.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }
    }
}
