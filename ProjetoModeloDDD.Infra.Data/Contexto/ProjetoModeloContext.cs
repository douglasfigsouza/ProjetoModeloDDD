
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext:DbContext
    {
      /*  public ProjetoModeloContext()
            :base("ProjetoModeloDDD")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        //permite configurações customizadas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //remove convenções especificas.Nesse caso removendo a covenção de nome de tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //remove convenção que exclui em cascata
            modelBuilder.Conventions.Remove< OneToManyCascadeDeleteConvention > ();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                //configuração para tranformar palavara com sufixo id em primary key
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //configura todos os tipos de campo string como varchar(caso nao for informado)
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //caso nao informe o tamanho do campo sera um varchar de 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //aplica ao contexto as configurações definidas nessa classe
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutosConfiguration());
        }
        public override int SaveChanges()
        {
            //adiciona a data corrente no campo dataCadastro caso seja uma inserção, porem caso seja uma atualização nao seta o campo
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("dataCadastro") != null)) {

                if (entry.State == EntityState.Added)
                    entry.Property("dataCadastro").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("dataCadastro").IsModified = false;
            }
            return base.SaveChanges();
        }*/
    }
}
