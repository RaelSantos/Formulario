using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Domain.Entities
{
    public class Cliente
    {

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public int? DDD { get; set; }

        public int? Telefone { get; set; }

        public string Email { get; set; }
    }
}
