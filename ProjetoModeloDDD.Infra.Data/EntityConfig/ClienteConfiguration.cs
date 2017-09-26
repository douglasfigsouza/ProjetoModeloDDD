using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration:EntityTypeConfiguration<Cliente>
    {
        //def configurações especificas da table cliente
        public ClienteConfiguration()
        {
            HasKey(c => c.clienteId);

            Property(c => c.nomeCli)
                .IsRequired()
                .HasMaxLength(150);
            Property(c => c.sobrenomeCli)
                .IsRequired()
                .HasMaxLength(150);
            Property(c => c.emailCli)
                .IsRequired();
        }
    }
}
