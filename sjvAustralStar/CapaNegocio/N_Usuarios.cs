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
    
    public class N_Usuarios
    {
        public static DataTable Login(string usuario, string password)
        {
            D_Usuarios Obj = new D_Usuarios();
            Obj.Username = usuario;
            Obj.Password = password;
            return Obj.Login(Obj);
        }
        public static DataTable BusquedaSimple_Usuario()
        {
            D_Usuarios obj = new D_Usuarios();
            return obj.BusquedaSimple_Usuario();
        }
        public static DataTable BusquedaSimple_Cargo_Usuario()
        {
            D_Usuarios obj = new D_Usuarios();
            return obj.BusquedaSimple_Cargo_Usuario();
        }
        public static string Ingresar_Usuario(
            int tipodoc, 
            string ndoc, 
            string telef, 
            int idcargo, 
            string direc, 
            string email, 
            string usuario, 
            string passwrd, 
            string nombres, 
            string apellidos
            )
        {
            D_Usuarios obj = new D_Usuarios();
            obj.idTipoDocumento = tipodoc;
            obj.nroDocumento = ndoc;
            obj.Telefono = telef;
            obj.idCargo = idcargo;
            obj.Direccion = direc;
            obj.Email = email;
            obj.Username = usuario;
            obj.Password = passwrd;
            obj.Nombre = nombres;
            obj.Apellidos = apellidos;
            return obj.Insertar_Usuario(obj);
        }

        public static string Modificar_Usuario(
           int idusuario,
           int tipodoc,
           string ndoc,
           string telef,
           int idcargo,
           string direc,
           string email,
           string usuario,
           string passwrd,
           string nombres,
           string apellidos
           )
        {
            D_Usuarios obj = new D_Usuarios();
            obj.idUsuario = idusuario;
            obj.idTipoDocumento = tipodoc;
            obj.nroDocumento = ndoc;
            obj.Telefono = telef;
            obj.idCargo = idcargo;
            obj.Direccion = direc;
            obj.Email = email;
            obj.Username = usuario;
            obj.Password = passwrd;
            obj.Nombre = nombres;
            obj.Apellidos = apellidos;
            return obj.Modificar_Usuario(obj);
        }
        public static string Ingresar_Cargo_Usuario(string cargo, string descripcion)
        {
            D_Usuarios obj = new D_Usuarios();
            obj.nombreCargo = cargo;
            obj.descripcionCargo = descripcion;
            return obj.Insertar_CargoUsuario(obj);
        }
        public static string Modificar_Cargo_Usuario(string cargo, string descripcion)
        {
            D_Usuarios obj = new D_Usuarios();
            obj.nombreCargo = cargo;
            obj.descripcionCargo = descripcion;
            return obj.Modificar_CargoUsuario(obj);
        }
    }
}
