using WebAPI__Eduardo_Vera_20240906.Models;

namespace WebAPI__Eduardo_Vera_20240906.Services
{
    public interface IPrestamoService
    {
        List<Prestamo> prestamos();
        List<Prestamo> prestamoUsuario(int id);

        Prestamo prestamo(PrestamoDTO prestamo);

        Prestamo cambiarEstado(int id, Prestamo prestamo);


    }
}
