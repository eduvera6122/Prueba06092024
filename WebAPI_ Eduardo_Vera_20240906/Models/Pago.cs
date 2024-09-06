using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPI__Eduardo_Vera_20240906.Models
{
    public partial class Pago
    {
        public int PagoId { get; set; }
        public int? PrestamoId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public string? MetodoPago { get; set; }

        public virtual Prestamo? Prestamo { get; set; }

        [JsonIgnore]
        public virtual Usuario? Usuario { get; set; }
    }
}
