using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Venta
    {
        public static string Insertar(int idcliente,
                int idcomprobante,
                int idusuario,
                DateTime fecha,
                string nrocomprobante,
                DataTable dtDetalles,
                decimal monto
            )
        {
            D_Venta obj = new D_Venta();
            obj.IDCliente = idcliente;
            obj.IDComprobante = idcomprobante;
            obj.IDUsuario = idusuario;
            obj.Fecha = fecha;
            obj.NroComprobante = nrocomprobante;
            obj.TotalVenta = monto;

            List<D_DetalleVenta> detalles = new List<D_DetalleVenta>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                D_DetalleVenta detalle = new D_DetalleVenta();
                detalle.Iddetalle_venta = Convert.ToInt32(row[""].ToString());
                detalle.IDProducto = Convert.ToString(row["idproducto"].ToString());
                detalle.Cantidad = Convert.ToDecimal(row["cantidad"].ToString());
                detalle.SubTotal=Convert.ToDecimal(row["subtotal"].ToString());

                detalles.Add(detalle);
            }
            return obj.Insertar(obj, detalles);
        }
    }
}
