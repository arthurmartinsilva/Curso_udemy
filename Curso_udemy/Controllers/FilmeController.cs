using Curso_udemy.Models;
using Curso_udemy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso_udemy.Controllers
{
    public class FilmeController : Controller
    {
        public List<FilmeModel> filmes = new List<FilmeModel>()
            {
                new FilmeModel
                {
                    id = 1,
                    nome = "Duro de Matar X"
                },
                new FilmeModel
                {
                    id = 2,
                    nome = "Harry Potter"
                }
            };

        // GET: todos os filmes
        public ActionResult listaFilmes()
        {        
            return View(filmes);
        }

        // GET: pega filme por id
        public ActionResult listaFilmeById(int id)
        {
            var filme = filmes.Where(p => p.id == id).First();
            
            return View(filme);
        }
    }
}