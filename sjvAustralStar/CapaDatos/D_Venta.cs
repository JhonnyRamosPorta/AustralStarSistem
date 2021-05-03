using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class D_Venta
    {
        private int _idVenta;
        private int _idComprobante;
        private int _idCliente;
        private int _idUsuario;
        private DateTime _fecha;
        private string _nrocomprobante;
        private decimal _montototal;

        public int IDVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }
        public int IDComprobante
        {
            get { return _idComprobante; }
            set { _idComprobante = value; }
        }
        public int IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public int IDUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public string NroComprobante
        {
            get { return _nrocomprobante; }
            set { _nrocomprobante = value; }
        }
        public decimal TotalVenta
        {
            get { return _montototal; }
            set { _montototal = value; }
        }

        public string Insertar(D_Venta Venta, List<D_DetalleVenta> Detalle)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                MySqlTransaction SqlTra = SqlCon.BeginTransaction();

                //Establecer el Comando
                MySqlCommand SqlCmd = new MySqlCommand();

                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "sjv_spInsertar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIdventa = new MySqlParameter();
                ParIdventa.ParameterName = "idventa";
                ParIdventa.MySqlDbType = MySqlDbType.Int32;
                ParIdventa.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdventa);

                MySqlParameter ParIDComprobante = new MySqlParameter();
                ParIDComprobante.ParameterName = "idtblcomprobante";
                ParIDComprobante.MySqlDbType = MySqlDbType.Int32;
                ParIDComprobante.Value = Venta.IDComprobante;
                SqlCmd.Parameters.Add(ParIDComprobante);

                MySqlParameter ParIDCliente = new MySqlParameter();
                ParIDCliente.ParameterName = "idcliente";
                ParIDCliente.MySqlDbType = MySqlDbType.Int32;
                ParIDCliente.Value = Venta.IDCliente;
                SqlCmd.Parameters.Add(ParIDCliente);

                MySqlParameter ParIDUsuario = new MySqlParameter();
                ParIDUsuario.ParameterName = "idusuario";
                ParIDUsuario.MySqlDbType = MySqlDbType.Int32;
                ParIDUsuario.Value = Venta.IDUsuario;
                SqlCmd.Parameters.Add(ParIDUsuario);

                MySqlParameter ParFecha = new MySqlParameter();
                ParFecha.ParameterName = "fecha";
                ParFecha.MySqlDbType = MySqlDbType.DateTime;
                ParFecha.Value = Venta.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                MySqlParameter ParMontoTotal = new MySqlParameter();
                ParMontoTotal.ParameterName = "MontoTotal";
                ParMontoTotal.MySqlDbType = MySqlDbType.Decimal;
                ParMontoTotal.Value = Venta.IDCliente;
                SqlCmd.Parameters.Add(ParMontoTotal);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


                IDVenta = Int32.Parse(SqlCmd.Parameters["@idventa"].Value.ToString());

                //List<D_DetalleVenta> Detalle
                if (rpta.Equals("OK"))
                {
                    //Obtener el código del ingreso generado
                    this.IDVenta = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    foreach (D_DetalleVenta det in Detalle)
                    {
                        det.Idventa = this.IDVenta;
                        //Llamar al método insertar de la clase DDetalle_Ingreso
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {


                            break;
                        }
                        else
                        {
                            //FUTURA ACTUALIZACION DE STOC


                        }
                    }

                }


                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();

                    rpta = "OK" + IDVenta;


                }
                else
                {
                    SqlTra.Rollback();
                }

            }
            catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

                SqlCon = null;
            }
            return rpta;
        }
    }
}
