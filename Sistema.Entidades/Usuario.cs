namespace Sistema.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Username { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }

    }
}
