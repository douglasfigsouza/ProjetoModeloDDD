
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Services;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    //implemta a interface idisposable para conseguir destruir esse objeto
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoModeloContext Db = new ProjetoModeloContext();
        Conexao conn = new Conexao();
        private Cliente cliente;

        public RepositoryBase()
        {
            cliente = new Cliente();
        }

        private enum Procedures
        {
            PBSP_INSCLIENTE
        }
        public void Add(TEntity obj)
        {
            cliente.nomeCli = "Douglas";
            cliente.sobrenomeCli = "Mata";
            cliente.emailCli = "douglasfigsouza@gmail.com";
            cliente.ativoCli = true;
            
            conn.ExecuteProcedure(Procedures.PBSP_INSCLIENTE);
            conn.AddParameter("@nomeCli",cliente.nomeCli);
            conn.AddParameter("@sobrenomeCli", cliente.sobrenomeCli);
            conn.AddParameter("@emailCli", cliente.emailCli);
            conn.AddParameter("@ativoCli", cliente.ativoCli);

            conn.ExecuteNonQuery();

            //Db.Set<TEntity>().Add(obj);
            //Db.SaveChanges();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return null;// Db.Set<TEntity>().ToList();

        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
