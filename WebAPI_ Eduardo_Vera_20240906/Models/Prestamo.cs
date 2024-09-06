using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPI__Eduardo_Vera_20240906.Models
{
    public partial class Prestamo
    {
        public Prestamo()
        {
            Pagos = new HashSet<Pago>();
        }

        public int PrestamoId { get; set; }
        public int? SolicitudId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public decimal MontoPrestado { get; set; }
        public decimal TasaInteres { get; set; }
        public string Estado { get; set; } = null!;

        public virtual SolicitudPrestamo? Solicitud { get; set; }

        [JsonIgnore]
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
