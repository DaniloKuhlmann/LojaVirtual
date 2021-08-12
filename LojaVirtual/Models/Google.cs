using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class GoogleAccount
    {
        public int Id { get; set; }
        public string Nameidentifier { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
