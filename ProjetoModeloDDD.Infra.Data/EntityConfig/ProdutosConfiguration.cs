using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutosConfiguration:EntityTypeConfiguration<Produto>
    {
        public ProdutosConfiguration()
        {
            HasKey(p => p.produtoId);

            Property(p => p.descProd)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.valorProd)
                .IsRequired();

            //informa que a classe cliente possui um relacionamento de 1 para muito com a classe produto,
            //e informa a foreingkey
            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.clienteId);
        }
    }
}
