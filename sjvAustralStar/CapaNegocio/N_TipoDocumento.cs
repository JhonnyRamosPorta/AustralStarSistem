using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N_TipoDocumento
    {
        public static DataTable BusquedaSimple_Tipo_Documento()
        {
            D_TipoDocumento obj = new D_TipoDocumento();
            return obj.BusquedaSimple_Tipo_Documento();
        }

        public static string Ingresar_Tipo_Documento(string nombre, string descripcion)
        {
            D_TipoDocumento obj = new D_TipoDocumento();
            obj.NombreTipoDocumento = nombre;
            obj.DescripcionTipoDocumento = descripcion;
            return obj.Insertar_TipoDocumento(obj);
        }

        public static string Modificar_Tipo_Documento(int id, string nombre, string des)
        {
            D_TipoDocumento obj = new D_TipoDocumento();
            obj.idTipoDocumento = id;
            obj.NombreTipoDocumento = nombre;
            obj.DescripcionTipoDocumento = des;
            return obj.Modificar_TipoDocumento(obj);
        }
    }

}
