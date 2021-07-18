using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LojaVirtual.Models
{
    public partial class Users
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        [Required]
        public GoogleAccount Google { get; set; }
        public lojas Loja { get; set; }
        public Endereço Endereço { get; set; }
        [Required]
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }

    }
}
