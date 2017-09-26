using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Mvc.ViewModels;

namespace ProjetoModeloDDD.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelsToDomainMappings"; }
        }
        protected override void Configure()
        {
            //faz o mapeamento de model apar viewmodel
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto,ProdutoViewModel>();
        }
    }
}