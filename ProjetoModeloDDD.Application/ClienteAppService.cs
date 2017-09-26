using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Interfaces.IServices;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _iClienteService;
        public ClienteAppService(IClienteService iClienteService)
            : base(iClienteService)
        {
            _iClienteService = iClienteService;
        }

        public IEnumerable<Cliente> obterClientesEspeciais()
        {
            return _iClienteService.obterClientesEspeciais(_iClienteService.GetAll());
        }
    }
}
