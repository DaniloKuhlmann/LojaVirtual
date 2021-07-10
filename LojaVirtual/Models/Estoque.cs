using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Estoque
    {
        [Required]
        public int id { get; set; }
        public lojas Loja { get; set; }
        public Produtos Produto { get; set; }
        public int Quantidade { get; set; }
        public double PreçoCompra { get; set; }
        public double ProçoVenda { get; set; }
    }
}
