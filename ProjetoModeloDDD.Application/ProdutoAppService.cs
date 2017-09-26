using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Interfaces.IServices;
using ProjetoModeloDDD.Application.Interface;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>,  IProdutoAppService
    {
        private readonly IProdutoService _iProdutoService;
        public ProdutoAppService(IProdutoService iProdutoService)
            : base(iProdutoService)
        {
            _iProdutoService = iProdutoService;
        }

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _iProdutoService.BuscaPorNome(nome);
        }
    }
}
