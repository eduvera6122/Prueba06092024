using WebAPI__Eduardo_Vera_20240906.Models;

namespace WebAPI__Eduardo_Vera_20240906.Services
{
    public class UsuarioService : IUsuarioService
    {

        private Prueba06092024Context _context;

        public UsuarioService(Prueba06092024Context context)
        {
            _context = context;
        }

        public Usuario crearUsuario(UsuarioDTO usuario)
        {
            Usuario usuario1 = new Usuario();

            usuario1.Nombre = usuario.Nombre;
            usuario1.Password = usuario.Password;
            usuario1.Tipo = usuario.Tipo;
            usuario1.Correo = usuario.Correo;
            usuario1.Telefono = usuario.Telefono;
            usuario1.Direccion = usuario.Direccion;

            _context.Usuarios.Add(usuario1);
            int result = _context.SaveChanges();

            if(result > 0)
            {
                return usuario1;
            }else
            {
                return null;
            }
        }

        public Usuario login(LoginDTO login)
        {
           return _context.Usuarios.Where(u => u.Nombre == login.Nombre && u.Password == login.Password).FirstOrDefault();

        }

        public Usuario usuario(int id)
        {
          return _context.Usuarios.Find(id);
        }

        public List<Usuario> usuarios()
        {
         return _context.Usuarios.ToList();
        }
    }
}
