using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Endereço
    {
        public int Id { get; set; }
        [Required]
        public string CEP { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Bairro { get; set; }
        [MaxLength(10)]
        public string Numero { get; set; }
    }
}
