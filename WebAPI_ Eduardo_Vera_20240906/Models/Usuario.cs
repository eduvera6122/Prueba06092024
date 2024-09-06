using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPI__Eduardo_Vera_20240906.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Pagos = new HashSet<Pago>();
            Prestamos = new HashSet<Prestamo>();
            SolicitudPrestamos = new HashSet<SolicitudPrestamo>();
        }

        public int UsuarioId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

        [JsonIgnore]
        public virtual ICollection<Pago> Pagos { get; set; }
        [JsonIgnore]
        public virtual ICollection<Prestamo> Prestamos { get; set; }
        [JsonIgnore]
        public virtual ICollection<SolicitudPrestamo> SolicitudPrestamos { get; set; }
    }
}
