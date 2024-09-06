using WebAPI__Eduardo_Vera_20240906.Models;

namespace WebAPI__Eduardo_Vera_20240906.Services
{
    public interface IPagoService
    {
        List<Pago> pagos();

        List<Pago> pagosUsuario(int id);


        Pago pago(PagoDTO pago);

    }
}
