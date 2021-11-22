using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NProveedor
    {
        public static DataTable Listar()
        {
            DProveedor Datos = new DProveedor();
            return Datos.Listar();
        }
        public static DataTable ListarProveedores()
        {
            DProveedor Datos = new DProveedor();
            return Datos.ListarProveedores();
        }

        public static DataTable ListarClientes()
        {
            DProveedor Datos = new DProveedor();
            return Datos.ListarClientes();
        }

        public static DataTable Buscar(string Valor)
        {
            DProveedor Datos = new DProveedor();
            return Datos.Buscar(Valor);
        }
        public static DataTable BuscarProveedores(string Valor)
        {
            DProveedor Datos = new DProveedor();
            return Datos.BuscarProveedores(Valor);
        }
        public static DataTable BuscarClientes(string Valor)
        {
            DProveedor Datos = new DProveedor();
            return Datos.BuscarClientes(Valor);
        }
        public static string Insertar(string TipoProveedor, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Celular, string Email)
        {
            DProveedor Datos = new DProveedor();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La persona ya existe.";
            }
            else
            {
                Proveedor Obj = new Proveedor();
                Obj.TipoProveedor = TipoProveedor;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Celular = Celular;
                Obj.Email = Email;
                return Datos.Insertar(Obj);
            }
        }

       

        
    }
}
