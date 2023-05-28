using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExeRibeiroCipriano.Models
{
    public class veiculo
    {
        [Required]
        public string chassis { get; set; }
        [Required]
        public string transmissao { get; set; }
        [Required]
        public string fabricante { get; set; }

    }
}