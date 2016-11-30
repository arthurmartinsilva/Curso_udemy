using Curso_udemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace Curso_udemy.Controllers
{
    public class ClientesController : Controller
    {
        private ApplicationDbContext _context;

        public ClientesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Cliente/listaClientes
        public ActionResult listaClientes()
        {
            var clientes = _context.Clientes.Include(c => c.MembroTipo).ToList();

            return View(clientes);
        }

        // GET: Cliente/listaClientesByID/
        public ActionResult listaClientesByID(int id)
        {
            var cliente = _context.Clientes.Where(p => p.id == id).First();

            return View(cliente);
        }

    }
}