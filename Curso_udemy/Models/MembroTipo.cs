using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curso_udemy.Models
{
    public class MembroTipo
    {
        public byte Id { get; set; }
        public short InscricaoAno { get; set; }
        public byte DuracaoMeses { get; set; }
        public byte Desconto { get; set; }
    }
}