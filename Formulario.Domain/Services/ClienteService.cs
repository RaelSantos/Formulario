using Formulario.Domain.Entities;
using Formulario.Domain.Interfaces.Repositories;
using Formulario.Domain.Interfaces.Services;

namespace Formulario.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
