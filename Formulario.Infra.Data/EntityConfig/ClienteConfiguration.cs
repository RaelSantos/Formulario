using Formulario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            // Setar Chave Primaria
            HasKey(c => c.ClienteId);

            // Setar Required e Maximo de caracteres
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            // Setar
           // Property(c => c.Telefone);

                   

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
