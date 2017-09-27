using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Mvc.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.Mvc.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }
        // GET: Clientes
        public ActionResult Index()
        {
            //o metodo get all retorna uma lista de clientes do tipo model, entao faz-se a conversão para view model
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetAll());
            return View(clienteViewModel);
        }
        public ActionResult Especiais()
        {
            //o metodo get all retorna uma lista de clientes do tipo model, entao faz-se a conversão para view model
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.obterClientesEspeciais());
            return View(clienteViewModel);
        }
        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteApp.Add(clienteDomain);
                return RedirectToAction("Index");
            }
            else {
                return View(cliente);
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                _clienteApp.Update(clienteDomain);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection f)
        {
            var cliente = _clienteApp.GetById(id);
            _clienteApp.Remove(cliente);
            return RedirectToAction("Index");
        }
    }
}
