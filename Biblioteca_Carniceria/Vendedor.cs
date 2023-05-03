// LOGIN -> VENDEDOR
namespace Biblioteca_Carniceria
{
    public class Vendedor : Usuario
    {
        #region CONSTRUCTOR
        public Vendedor(string email, string password, string nombre, string apellido) : base(email,password,nombre,apellido)
        {
            email = string.Empty;
            password = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
        }
        #endregion
    }
}