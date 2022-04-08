using CRUD_DadosLocais.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_DadosLocais.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult lista_clientes()
        {
            return View(Dados.todos_os_clientes());
        }

        public IActionResult adcionar_clientes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult adcionar_clientes(Cliente cliente)
        {
            Dados.adcionar_cliente(cliente);
            return RedirectToAction("adcionar_clientes");
        }

        public IActionResult editar_cliente(int id)
        {            
            return View(Dados.dados_cliente(id));
        }

        [HttpPost]
        public IActionResult editar_cliente(Cliente c)
        {
            Dados.editar_cliente(c);
            return RedirectToAction("lista_clientes");
        }

        public IActionResult eliminar_cliente(int id)
        {
            //eliminar o cliente selecionado
            Dados.eliminar_cliente(id);
            return RedirectToAction("lista_clientes");
        }
    }
}
