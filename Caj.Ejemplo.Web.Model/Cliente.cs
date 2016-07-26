using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Caj.Ejemplo.Web.Model
{
    public class Cliente
    {
        [Display(Name = "id")]
        public int idCliente { get; set; }

        [Display(Name = "Nombre Cliente")]
        public string Nombre { get; set; }

        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
    }
}
