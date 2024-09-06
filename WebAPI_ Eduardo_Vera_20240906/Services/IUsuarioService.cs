using WebAPI__Eduardo_Vera_20240906.Models;

namespace WebAPI__Eduardo_Vera_20240906.Services
{
    public interface IUsuarioService
    {
        List<Usuario> usuarios();

        Usuario login(LoginDTO login);

        Usuario usuario(int id);

        Usuario crearUsuario(UsuarioDTO usuario);

    }
}
