using WebAPI__Eduardo_Vera_20240906.Models;

namespace WebAPI__Eduardo_Vera_20240906.Services
{
    public interface ISolicitudService
    {
        List<SolicitudPrestamo> solicitudes();

        List<SolicitudPrestamo> solicitudesUsuario(int id);


        SolicitudPrestamo solicitud(SolicitudDTO solicitud);

        SolicitudPrestamo cambiarEstado(int id, SolicitudPrestamo solicitud);


    }
}
