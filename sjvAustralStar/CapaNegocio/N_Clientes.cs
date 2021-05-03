using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    //Métodos para comunicarnos con la capa datos
    public class N_Clientes
    {
        public static DataTable BusquedaSimple_Cliente()
        {
            D_Clientes obj = new D_Clientes();
            return obj.BusquedaSimple_Cliente();
        }
        public static string Ingresar_Cliente(
            string nombre,
            string apellido,
            int idtdoc,
            string nrodoc,
            string direccion,
            string telef,
            string email)
        {
            D_Clientes obj = new D_Clientes();
            obj.Nombre = nombre;
            obj.Apellidos = apellido;
            obj.IDTipoDocumento = idtdoc;
            obj.NroDocumento = nrodoc;
            obj.Direccion = direccion;
            obj.NroTelefono = telef;
            obj.Email = email;
            return obj.Insertar_Cliente(obj);
        }
        public static string Modificar_Cliente(
            int idcli,
            string nombre,
            string apellido,
            int idtdoc,
            string nrodoc,
            string direccion,
            string telef,
            string email)
        {
            D_Clientes obj = new D_Clientes();
            obj.IDCliente = idcli;
            obj.Nombre = nombre;
            obj.Apellidos = apellido;
            obj.IDTipoDocumento = idtdoc;
            obj.NroDocumento = nrodoc;
            obj.Direccion = direccion;
            obj.NroTelefono = telef;
            obj.Email = email;
            return obj.Modificar_Cliente(obj);
        }
    }
}
