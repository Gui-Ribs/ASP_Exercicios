using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExeRibeiroCipriano.Models
{
    public class Funcionario
    {
        public int? codigo { get; set; }

        public string nome { get; set; }

        public string funcao { get; set; }

    }
}