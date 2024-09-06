namespace WebAPI__Eduardo_Vera_20240906.Models
{

    public class UsuarioDTO
    {
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
    }

    public class LoginDTO
    {
        public string Nombre { get; set; } = null!;
        public string Password { get; set; } = null!;
    }

    public class SolicitudDTO
    {
        public int? UsuarioId { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public decimal MontoSolicitado { get; set; }
        public string Estado { get; set; } = null!;
    }

    public class PrestamoDTO
    {
        public int? SolicitudId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public decimal MontoPrestado { get; set; }
        public decimal TasaInteres { get; set; }
        public string Estado { get; set; } = null!;
    }


    public class PagoDTO
    {
        public int? PrestamoId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public string? MetodoPago { get; set; }
    }

}
