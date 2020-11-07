using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Niurbis_Parcial2AP2.Models
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        [Range(minimum: 1, maximum: 1000000, ErrorMessage = "Eliga un rango de 1 a 1000000")]
        public double Monto { get; set; }
        public double Balance { get; set; }
    }
}
