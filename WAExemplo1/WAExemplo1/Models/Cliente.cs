using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAExemplo1.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }
    }
}
