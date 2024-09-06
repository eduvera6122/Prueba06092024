using WebAPI__Eduardo_Vera_20240906.Models;

namespace WebAPI__Eduardo_Vera_20240906.Services
{
    public class PagoService : IPagoService
    {
        private  Prueba06092024Context _context;

        public PagoService(Prueba06092024Context context)
        {
            _context = context;
        }

        public Pago pago(PagoDTO pago)
        {
            Pago pago1 = new Pago();    
            pago1.PrestamoId = pago.PrestamoId;
            pago1.UsuarioId = pago.UsuarioId;
            pago1.FechaPago = pago.FechaPago;
            pago1.MontoPagado = pago.MontoPagado;
            pago1.MetodoPago = pago.MetodoPago;

            _context.Pagos.Add(pago1);

            int result = _context.SaveChanges();

            if(result > 0)
            {
                return pago1;
            }else {  
                return null;
            }


        }

        public List<Pago> pagos()
        {
            return _context.Pagos.ToList();

        }

        public List<Pago> pagosUsuario(int id)
        {

            return _context.Pagos.Where(p => p.UsuarioId == id).ToList();
        }
    }
}
