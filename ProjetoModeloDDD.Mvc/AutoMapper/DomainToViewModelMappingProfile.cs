using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Mvc.ViewModels;

namespace ProjetoModeloDDD.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public override string ProfileName
        {
           get { return "ViewModelsToDomainMappings"; }
        }
        protected override void Configure() {
            //faz o mapeamento de viewmodel para model
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}