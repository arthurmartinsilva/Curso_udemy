using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso_udemy.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public MembroTipo MembroTipo { get; set; }
        [Required]
        [StringLength(255)]
        public string nome { get; set; }
        public bool inscritoToNewsLetter { get; set; }
        public byte MembroTipoesId { get; set; }
    }
}