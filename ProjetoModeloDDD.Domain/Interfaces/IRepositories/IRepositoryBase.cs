using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    //trate TEntity como uma classe
    public interface IRepositoryBase<TEntity> where TEntity:class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
