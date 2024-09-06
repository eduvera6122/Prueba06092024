using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPI__Eduardo_Vera_20240906.Models
{
    public partial class SolicitudPrestamo
    {
        public SolicitudPrestamo()
        {
            Prestamos = new HashSet<Prestamo>();
        }

        public int SolicitudId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public decimal MontoSolicitado { get; set; }
        public string Estado { get; set; } = null!;

        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<Prestamo> Prestamos { get; set; }
    }
}
