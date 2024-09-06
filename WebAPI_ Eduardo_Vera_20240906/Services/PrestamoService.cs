using WebAPI__Eduardo_Vera_20240906.Models;

namespace WebAPI__Eduardo_Vera_20240906.Services
{
    public class PrestamoService : IPrestamoService
    {
        private Prueba06092024Context _context;

        public PrestamoService(Prueba06092024Context context)
        {
            _context = context;
        }

        public Prestamo cambiarEstado(int id, Prestamo prestamo)
        {

            Prestamo prestamo1 = _context.Prestamos.Find(id);

            if (prestamo1 == null)
            {
                return null;
            }

            prestamo1.Estado = prestamo.Estado;

            _context.Prestamos.Update(prestamo1);

            int result = _context.SaveChanges();

            if (result > 0)
            {
                return prestamo1;
            }
            else
            {
                return null;
            }
        }



        public Prestamo prestamo(PrestamoDTO prestamo)
        {
            Prestamo prestamo1 = new Prestamo();

            prestamo1.UsuarioId = prestamo.UsuarioId;
            prestamo1.FechaAprobacion = prestamo.FechaAprobacion;
            prestamo1.MontoPrestado = prestamo.MontoPrestado;
            prestamo1.Estado = prestamo.Estado;

            _context.Prestamos.Add(prestamo1);

            int result = _context.SaveChanges();

            if (result > 0)
            {
                return prestamo1;
            }
            else
            {
                return null;
            }



        }

        public List<Prestamo> prestamos()
        {
            return _context.Prestamos.ToList();


        }

        public List<Prestamo> prestamoUsuario(int id)
        {
            return _context.Prestamos.Where(p => p.UsuarioId == id).ToList();

        }
    }
}
