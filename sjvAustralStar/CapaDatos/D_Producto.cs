using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class D_Producto
    {
        private string _idProducto;
        private string _idCategoria;
        private string _nombreCategoria;
        private string _descripcionCategoria;
        private string _nombreProducto;
        private string _descripcionProducto;
        private decimal _precio;
        private int _status;

        public string IDProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        public string IDCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }
        public string NombreCategoria
        {
            get { return _nombreCategoria; }
            set { _nombreCategoria = value; }
        }
        public string DescripcionCategoria
        {
            get { return _descripcionCategoria; }
            set { _descripcionCategoria = value; }
        }
        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }
        public string DescripcionProducto
        {
            get { return _descripcionProducto; }
            set { _descripcionProducto = value; }
        }
        public decimal Precio { get => _precio; set => _precio = value; }
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public D_Producto()
        {

        }

        public D_Producto(
            string idpr,
            string idcat,
            string nomcat,
            string descat,
            string nompro,
            string despro,
            decimal precio,
            int status
            )
        {
            this.IDProducto = idpr;
            this.IDCategoria = idcat;
            this.NombreCategoria = nomcat;
            this.DescripcionCategoria = descat;
            this.NombreProducto = nompro;
            this.DescripcionProducto = despro;
            this.Precio = precio;
            this.Status = status;
        }

        public DataTable BusquedaSimple_Categoria()
        {
            DataTable DtResultado = new DataTable("ListadoCategoria");
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = mySqlConnection;
                sqlCmd.CommandText = "sjv_spMostrar_Categoria";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter mySqlData = new MySqlDataAdapter(sqlCmd);
                mySqlData.Fill(DtResultado);

            }
            catch (Exception ex1)
            {
                DtResultado = null;

            }
            return DtResultado;
        }

        public string Insertar_Categoria(D_Producto producto)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sjv_spInsertar_Categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "id";
                ParIDCategoria.MySqlDbType = MySqlDbType.VarChar;
                ParIDCategoria.Size = 3;
                ParIDCategoria.Value = producto.IDCategoria;
                SqlCmd.Parameters.Add(ParIDCategoria);

                MySqlParameter ParNombreCategoria = new MySqlParameter();
                ParNombreCategoria.ParameterName = "nombre";
                ParNombreCategoria.MySqlDbType = MySqlDbType.VarChar;
                ParNombreCategoria.Size = 45;
                ParNombreCategoria.Value = producto.NombreCategoria;
                SqlCmd.Parameters.Add(ParNombreCategoria);

                MySqlParameter ParDescCategoria = new MySqlParameter();
                ParDescCategoria.ParameterName = "descripcion";
                ParDescCategoria.MySqlDbType = MySqlDbType.VarChar;
                ParDescCategoria.Size = 150;
                ParDescCategoria.Value = producto.DescripcionCategoria;
                SqlCmd.Parameters.Add(ParDescCategoria);

                MySqlParameter ParEstadoCategoria = new MySqlParameter();
                ParEstadoCategoria.ParameterName = "estado";
                ParEstadoCategoria.MySqlDbType = MySqlDbType.Int32;
                ParEstadoCategoria.Value = producto.Status;
                SqlCmd.Parameters.Add(ParEstadoCategoria);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex4)
            {
                rpta = ex4.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string Modificar_Categoria(D_Producto producto)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sjv_spModificar_Categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "id";
                ParIDCategoria.MySqlDbType = MySqlDbType.VarChar;
                ParIDCategoria.Size = 3;
                ParIDCategoria.Value = producto.IDCategoria;
                SqlCmd.Parameters.Add(ParIDCategoria);

                MySqlParameter ParNombreCategoria = new MySqlParameter();
                ParNombreCategoria.ParameterName = "nombre";
                ParNombreCategoria.MySqlDbType = MySqlDbType.VarChar;
                ParNombreCategoria.Size = 45;
                ParNombreCategoria.Value = producto.NombreCategoria;
                SqlCmd.Parameters.Add(ParNombreCategoria);

                MySqlParameter ParDescCategoria = new MySqlParameter();
                ParDescCategoria.ParameterName = "descripcion";
                ParDescCategoria.MySqlDbType = MySqlDbType.VarChar;
                ParDescCategoria.Size = 150;
                ParDescCategoria.Value = producto.DescripcionCategoria;
                SqlCmd.Parameters.Add(ParDescCategoria);

                MySqlParameter ParEstadoCategoria = new MySqlParameter();
                ParEstadoCategoria.ParameterName = "estado";
                ParEstadoCategoria.MySqlDbType = MySqlDbType.Int32;
                ParEstadoCategoria.Value = producto.Status;
                SqlCmd.Parameters.Add(ParEstadoCategoria);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se modifico el Registro";
            }
            catch (Exception ex4)
            {
                rpta = ex4.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable BusquedaSimple_Producto()
        {
            DataTable DtResultado = new DataTable("ListadoProducto");
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = mySqlConnection;
                sqlCmd.CommandText = "sjv_spMostrar_Productos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter mySqlData = new MySqlDataAdapter(sqlCmd);
                mySqlData.Fill(DtResultado);

            }
            catch (Exception ex2)
            {
                DtResultado = null;

            }
            return DtResultado;
        }

        public string Insertar_Producto(D_Producto producto)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sjv_spInsertar_Productos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParNombreProducto = new MySqlParameter();
                ParNombreProducto.ParameterName = "nombre";
                ParNombreProducto.MySqlDbType = MySqlDbType.VarChar;
                ParNombreProducto.Size = 45;
                ParNombreProducto.Value = producto.NombreProducto;
                SqlCmd.Parameters.Add(ParNombreProducto);

                MySqlParameter ParDesProducto = new MySqlParameter();
                ParDesProducto.ParameterName = "descripcion";
                ParDesProducto.MySqlDbType = MySqlDbType.VarChar;
                ParDesProducto.Size = 150;
                ParDesProducto.Value = producto.DescripcionProducto;
                SqlCmd.Parameters.Add(ParDesProducto);

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "idcat";
                ParIDCategoria.MySqlDbType = MySqlDbType.VarChar;
                ParDesProducto.Size = 3;
                ParIDCategoria.Value = producto.IDCategoria;
                SqlCmd.Parameters.Add(ParIDCategoria);

                MySqlParameter ParPrecio = new MySqlParameter();
                ParPrecio.ParameterName = "precio";
                ParPrecio.MySqlDbType = MySqlDbType.Decimal;
                ParPrecio.Value = producto.Precio;
                SqlCmd.Parameters.Add(ParPrecio);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex4)
            {
                rpta = ex4.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string Modificar_Producto(D_Producto producto)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sjv_spModificar_Productos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDProducto = new MySqlParameter();
                ParIDProducto.ParameterName = "idpro";
                ParIDProducto.MySqlDbType = MySqlDbType.Int32;
                ParIDProducto.Value = producto.IDProducto;
                SqlCmd.Parameters.Add(ParIDProducto);

                MySqlParameter ParNombreProducto = new MySqlParameter();
                ParNombreProducto.ParameterName = "nombre";
                ParNombreProducto.MySqlDbType = MySqlDbType.VarChar;
                ParNombreProducto.Size = 45;
                ParNombreProducto.Value = producto.NombreProducto;
                SqlCmd.Parameters.Add(ParNombreProducto);

                MySqlParameter ParDesProducto = new MySqlParameter();
                ParDesProducto.ParameterName = "descripcion";
                ParDesProducto.MySqlDbType = MySqlDbType.VarChar;
                ParDesProducto.Size = 150;
                ParDesProducto.Value = producto.DescripcionProducto;
                SqlCmd.Parameters.Add(ParDesProducto);

                MySqlParameter ParIDCategoria = new MySqlParameter();
                ParIDCategoria.ParameterName = "idcat";
                ParIDCategoria.MySqlDbType = MySqlDbType.VarChar;
                ParDesProducto.Size = 3;
                ParIDCategoria.Value = producto.IDCategoria;
                SqlCmd.Parameters.Add(ParIDCategoria);

                MySqlParameter ParPrecio = new MySqlParameter();
                ParPrecio.ParameterName = "precio";
                ParPrecio.MySqlDbType = MySqlDbType.Decimal;
                ParPrecio.Value = producto.Precio;
                SqlCmd.Parameters.Add(ParPrecio);
                

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se modifico el Registro";
            }
            catch (Exception ex4)
            {
                rpta = ex4.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

    }
}
