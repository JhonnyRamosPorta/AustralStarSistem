using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace CapaDatos
{
    public class D_DetalleVenta
    {
        private int _Iddetalle_venta;
        private int _Idventa;
        private string _IdProducto;
        private decimal _Cantidad;
        private decimal _subtotal;
        //Propiedades
        public int Iddetalle_venta
        {
            get { return _Iddetalle_venta; }
            set { _Iddetalle_venta = value; }
        }


        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }

        public string IDProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }


        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public decimal SubTotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }


        //Constructores
        public D_DetalleVenta()
        {

        }

        public D_DetalleVenta(
            int _Iddetalle_venta,
            int _Idventa,
            string _IdProducto,
            decimal _Cantidad,
            decimal _subtotal)
        {
            this.Iddetalle_venta = _Iddetalle_venta;
            this.Idventa = _Idventa;
            this.IDProducto = _IdProducto;
            this.Cantidad = _Cantidad;
            this.SubTotal = _subtotal;
        }

        public string Insertar(D_DetalleVenta detalleVenta,
            ref MySqlConnection SqlCon, ref MySqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "sjv_spInsertar_DetalleVenta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDVenta = new MySqlParameter();
                ParIDVenta.ParameterName = "idventa";
                ParIDVenta.MySqlDbType = MySqlDbType.Int32;
                ParIDVenta.Value = detalleVenta.Idventa;
                SqlCmd.Parameters.Add(ParIDVenta);

                MySqlParameter ParIDProducto = new MySqlParameter();
                ParIDProducto.ParameterName = "idproducto";
                ParIDProducto.MySqlDbType = MySqlDbType.VarChar;
                ParIDProducto.Size = 7;
                ParIDProducto.Value = detalleVenta.IDProducto;
                SqlCmd.Parameters.Add(ParIDProducto);

                MySqlParameter ParCantidad = new MySqlParameter();
                ParCantidad.ParameterName = "cantidad";
                ParCantidad.MySqlDbType = MySqlDbType.Decimal;
                ParCantidad.Value = detalleVenta.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                MySqlParameter ParSubtotal = new MySqlParameter();
                ParSubtotal.ParameterName = "subtotal";
                ParCantidad.MySqlDbType = MySqlDbType.Decimal;
                ParSubtotal.Value = detalleVenta.SubTotal;
                SqlCmd.Parameters.Add(ParSubtotal);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
    }
}
