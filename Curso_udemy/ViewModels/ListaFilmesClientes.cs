using Curso_udemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curso_udemy.ViewModels
{
    public class ListaFilmesClientes
    {
        public List<FilmeModel> Filmes { get; set; }
        public List<Clientes> Clientes { get; set; }
    }
}