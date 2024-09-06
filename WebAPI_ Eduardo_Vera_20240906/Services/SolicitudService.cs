using Microsoft.EntityFrameworkCore;
using WebAPI__Eduardo_Vera_20240906.Models;

namespace WebAPI__Eduardo_Vera_20240906.Services
{
    public class SolicitudService : ISolicitudService
    {
        private Prueba06092024Context _context;

        public SolicitudService(Prueba06092024Context context)
        {
            _context = context;
        }

        public SolicitudPrestamo cambiarEstado(int id, SolicitudPrestamo solicitud)
        {
            SolicitudPrestamo solicitud1 = _context.SolicitudPrestamos.Find(id);

            if(solicitud1 == null)
            {
                return null;
            }

            solicitud1.Estado = solicitud.Estado;

            _context.SolicitudPrestamos.Update(solicitud1);
            int result = _context.SaveChanges();

            if(result > 0)
            {
                return solicitud1;
            }
            else
            {
                return null;
            }

        }

        public SolicitudPrestamo solicitud(SolicitudDTO solicitud)
        {
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo();

            solicitud1.UsuarioId = solicitud.UsuarioId;
            solicitud1.FechaSolicitud = solicitud.FechaSolicitud;
            solicitud1.MontoSolicitado = solicitud.MontoSolicitado;
            solicitud1.Estado = solicitud.Estado;


            _context.SolicitudPrestamos.Add(solicitud1);
            int result = _context.SaveChanges();

            if(result > 0)
            {
                return solicitud1;
            }
            else
            {
                return null;
            }
        }

        public List<SolicitudPrestamo> solicitudes()
        {
           return _context.SolicitudPrestamos.
                Include(s => s.Usuario)
                .ToList(); 
        }

        public List<SolicitudPrestamo> solicitudesUsuario(int id)
        {
           return _context.SolicitudPrestamos.Where(s => s.UsuarioId == id).
                 Include(s => s.Usuario)
                .ToList(); 
        }
    }
}
