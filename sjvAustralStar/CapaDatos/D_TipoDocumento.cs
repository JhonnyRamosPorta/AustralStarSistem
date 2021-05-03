using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace CapaDatos
{
    public class D_TipoDocumento
    {
        private int _IdTipoDocumento;
        private string _NombreTipoDocumento;
        private string _DescripcionTipoDocumento;
        
        public int idTipoDocumento
        {
            get { return _IdTipoDocumento; }
            set { _IdTipoDocumento = value; }
        }
        public string NombreTipoDocumento
        {
            get { return _NombreTipoDocumento; }
            set { _NombreTipoDocumento = value; }
        }
        public string DescripcionTipoDocumento
        {
            get { return _DescripcionTipoDocumento; }
            set { _DescripcionTipoDocumento = value; }
        }
        public D_TipoDocumento()
        {

        }
        public D_TipoDocumento(int id, string nombre, string descripcion)
        {
            this.idTipoDocumento = id;
            this.NombreTipoDocumento = nombre;
            this.DescripcionTipoDocumento = descripcion;
        }
        public DataTable BusquedaSimple_Tipo_Documento()
        {
            DataTable DtResultado = new DataTable("ListadoTipoDocumentos");
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = mySqlConnection;
                sqlCmd.CommandText = "sjv_spMostrar_TipoDocumento";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter mySqlData = new MySqlDataAdapter(sqlCmd);
                mySqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public string Insertar_TipoDocumento(D_TipoDocumento _TipoDocumento)
        {
            string rpta = "";
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                mySqlConnection.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = mySqlConnection;
                SqlCmd.CommandText = "sjv_spInsertar_TipoDocumento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParNombre = new MySqlParameter();
                ParNombre.ParameterName = "nombre";
                ParNombre.MySqlDbType = MySqlDbType.VarChar;
                ParNombre.Size = 45;
                ParNombre.Value = _TipoDocumento.NombreTipoDocumento;
                SqlCmd.Parameters.Add(ParNombre);

                MySqlParameter ParDescripcion = new MySqlParameter();
                ParDescripcion.ParameterName = "descripcion";
                ParDescripcion.MySqlDbType = MySqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = _TipoDocumento.DescripcionTipoDocumento;
                SqlCmd.Parameters.Add(ParDescripcion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex1)
            {
                rpta = ex1.Message;
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open) mySqlConnection.Close();
            }
            return rpta;
        }

        public string Modificar_TipoDocumento(D_TipoDocumento _TipoDocumento)
        {
            string rpta = "";
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                mySqlConnection.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = mySqlConnection;
                SqlCmd.CommandText = "sjv_spModificar_TipoDocumento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDTDoc = new MySqlParameter();
                ParIDTDoc.ParameterName = "idtdoc";
                ParIDTDoc.MySqlDbType = MySqlDbType.Int32;
                ParIDTDoc.Value = _TipoDocumento.idTipoDocumento;
                SqlCmd.Parameters.Add(ParIDTDoc);

                MySqlParameter ParNombre = new MySqlParameter();
                ParNombre.ParameterName = "nombre";
                ParNombre.MySqlDbType = MySqlDbType.VarChar;
                ParNombre.Size = 45;
                ParNombre.Value = _TipoDocumento.NombreTipoDocumento;
                SqlCmd.Parameters.Add(ParNombre);

                MySqlParameter ParDescripcion = new MySqlParameter();
                ParDescripcion.ParameterName = "descripcion";
                ParDescripcion.MySqlDbType = MySqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = _TipoDocumento.DescripcionTipoDocumento;
                SqlCmd.Parameters.Add(ParDescripcion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se modifico el Registro";
            }
            catch (Exception ex1)
            {
                rpta = ex1.Message;
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open) mySqlConnection.Close();
            }
            return rpta;
        }

    }
}
