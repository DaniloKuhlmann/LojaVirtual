using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LojaVirtual.Models
{
    public partial class lojas
    {
        public int id { get; set; }
        public List<Users> users { get; set; }
        public Endereço Endereço { get; set; }
        [Required]
        public string Nome { get; set; }
        public List<Estoque> Estoques { get; set; }

    }
}
