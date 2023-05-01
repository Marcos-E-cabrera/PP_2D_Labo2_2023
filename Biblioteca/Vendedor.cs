namespace Biblioteca
{
    public class Vendedor : Usuario
    {
        private string nombre;
        private string apellido;

        public string Nombre { get; }
        public string Apellido { get; }

        public Vendedor(string email, string password, string nombre, string apellido) : base(email,password)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }


    }
}