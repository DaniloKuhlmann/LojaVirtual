using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Produtos
    {
        [Required]
        public int id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public List<Estoque> Estoques { get; set; }

    }
}
