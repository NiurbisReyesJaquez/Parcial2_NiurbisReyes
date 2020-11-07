using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Niurbis_Parcial2AP2.Models
{
    public class Cobros
    {
        [Key]
        public int CobrosId { get; set; }

        [ForeignKey("ClientesId")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        public double Monto { get; set; }

        public string Observaciones { get; set; }
        [ForeignKey("CobrosId")]

        public virtual List<CobrosDetalle> Detalle { get; set; } = new List<CobrosDetalle>();

        public Cobros()
        {
        }

        public void AgregarDetalle(int ventaId, double cobrado)
        {
            this.Detalle.Add(new CobrosDetalle()
            {
                VentasId = ventaId,
                Cobrado = cobrado
            }
            );

            this.Monto = this.Detalle.Sum(x => x.Cobrado);
        }

    }
}
