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
    public class N_Producto
    {
        public static DataTable BusquedaSimple_Categoria()
        {
            D_Producto obj = new D_Producto();
            return obj.BusquedaSimple_Categoria();
        }

        public static DataTable BusquedaSimple_Producto()
        {
            D_Producto obj = new D_Producto();
            return obj.BusquedaSimple_Producto();
        }

        public static string Ingresar_Categoria(
            string id,
            string nombre,
            string descripcion,
            int status
            )
        {
            D_Producto obj = new D_Producto();
            obj.IDProducto = id;
            obj.NombreCategoria = nombre;
            obj.DescripcionCategoria = descripcion;
            obj.Status = status;
            return obj.Insertar_Categoria(obj);
        }

        public static string Modificar_Categoria(
            string id,
            string nombre,
            string descripcion,
            int status)
        {
            D_Producto obj = new D_Producto();
            obj.IDCategoria = id;
            obj.NombreCategoria = nombre;
            obj.DescripcionCategoria = descripcion;
            obj.Status = status;
            return obj.Modificar_Categoria(obj);
        }

        public static string Ingresar_Producto(
            string nombre,
            string descripcion,
            string idcat,
            decimal precio
            )
        {
            D_Producto obj = new D_Producto();
            obj.NombreProducto = nombre;
            obj.DescripcionProducto = descripcion;
            obj.IDCategoria = idcat;
            obj.Precio = precio;
            return obj.Insertar_Producto(obj);
        }

        public static string Modificar_Producto(
            string id,
            string nombre,
            string descripcion,
            string idcat,
            decimal precio
            )
        {
            D_Producto obj = new D_Producto();
            obj.IDProducto = id;
            obj.NombreProducto = nombre;
            obj.DescripcionProducto = descripcion;
            obj.IDCategoria = idcat;
            obj.Precio = precio;
            return obj.Modificar_Producto(obj);
        }
    }
}
