using Formulario.Domain.Entities;
using Formulario.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Formulario.Infra.Data.Contexto
{
    public class FormularioContext : DbContext
    {
        public FormularioContext() : base("DbFormulario") { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desabilitar Pluralização de Tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Desabitar Delete em Cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Desabitar Delete em Cascata
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Configurar Entidades "Primary Key"
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            // Habilitar todas Propriedades para "VARCHAR"
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            // Tamanho
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // Setar Configuration
            modelBuilder.Configurations.Add(new ClienteConfiguration());

        }

    }
}