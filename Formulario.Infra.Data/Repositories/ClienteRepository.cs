using Formulario.Domain.Entities;
using Formulario.Domain.Interfaces;
using Formulario.Domain.Interfaces.Repositories;

namespace Formulario.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
