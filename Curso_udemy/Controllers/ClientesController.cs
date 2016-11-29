using Curso_udemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso_udemy.Controllers
{
    public class ClientesController : Controller
    {
        List<Clientes> clientes = new List<Clientes>
        {
            new Clientes
            {
                id = 2,
                nome = "Arthur"
            },
            new Clientes
            {
                id = 1,
                nome = "Bruna"
            }
        };

        // GET: Cliente/listaClientes
        public ActionResult listaClientes()
        {
            return View(clientes);
        }

        // GET: Cliente/listaClientesByID/
        public ActionResult listaClientesByID(int id)
        {
            var cliente = clientes.Where(p => p.id == id).First();

            return View(cliente);
        }

    }
}