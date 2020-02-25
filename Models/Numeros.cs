using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Numeros_Binarios_ASP.Models
{
    public class Numeros
    {
        [Required]
        public int[] Numero { get; set;}
    }
}
