using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class D_Clientes
    {
        private int _idCliente;
        private string _nombreCliente;
        private string _apellidosCliente;
        private int _idTipoDocumento;
        private string _nroDocumento;
        private string _direccionCliente;
        private string _nroTelefono;
        private string _email;

        public int IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public int IDTipoDocumento
        {
            get { return _idTipoDocumento; }
            set { _idTipoDocumento = value; }
        }
        public string Nombre
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }
        public string Apellidos
        {
            get { return _apellidosCliente; }
            set { _apellidosCliente = value; }
        }
        public string NroDocumento
        {
            get { return _nroDocumento; }
            set { _nroDocumento = value; }
        }
        public string Direccion
        {
            get { return _direccionCliente; }
            set { _direccionCliente = value; }
        }
        public string NroTelefono
        {
            get { return _nroTelefono; }
            set { _nroTelefono = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public D_Clientes()
        {

        }

        public D_Clientes(
            int idcliente,
            int idtdoc,
            string nombre,
            string apellidos,
            string nrodoc,
            string direccion,
            string nrotelef,
            string email
            )
        {
            this.IDCliente = idcliente;
            this.IDTipoDocumento = idtdoc;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.NroDocumento = nrodoc;
            this.Direccion = direccion;
            this.NroTelefono = nrotelef;
            this.Email = email;
        }

        public DataTable BusquedaSimple_Cliente()
        {
            DataTable DtResultado = new DataTable("ListadoClientes");
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = mySqlConnection;
                sqlCmd.CommandText = "sjv_spMostrar_Clientes";
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

        public string Insertar_Cliente(D_Clientes clientes)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sjv_spInsertar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIdTipoDoc = new MySqlParameter();
                ParIdTipoDoc.ParameterName = "idtdoc";
                ParIdTipoDoc.MySqlDbType = MySqlDbType.Int32;
                ParIdTipoDoc.Value = clientes.IDTipoDocumento;
                SqlCmd.Parameters.Add(ParIdTipoDoc);

                MySqlParameter ParNroDoc = new MySqlParameter();
                ParNroDoc.ParameterName = "nrodoc";
                ParNroDoc.MySqlDbType = MySqlDbType.VarChar;
                ParNroDoc.Size = 15;
                ParNroDoc.Value = clientes.NroDocumento;
                SqlCmd.Parameters.Add(ParNroDoc);

                MySqlParameter ParTelefono = new MySqlParameter();
                ParTelefono.ParameterName = "telefono";
                ParTelefono.MySqlDbType = MySqlDbType.VarChar;
                ParTelefono.Size = 15;
                ParTelefono.Value = clientes.NroTelefono;
                SqlCmd.Parameters.Add(ParTelefono);

                MySqlParameter ParDireccion = new MySqlParameter();
                ParDireccion.ParameterName = "direccion";
                ParDireccion.MySqlDbType = MySqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = clientes.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                MySqlParameter ParEmail = new MySqlParameter();
                ParEmail.ParameterName = "email";
                ParEmail.MySqlDbType = MySqlDbType.VarChar;
                ParEmail.Size = 45;
                ParEmail.Value = clientes.Email;
                SqlCmd.Parameters.Add(ParEmail);

                MySqlParameter ParNombres = new MySqlParameter();
                ParNombres.ParameterName = "nombre";
                ParNombres.MySqlDbType = MySqlDbType.VarChar;
                ParNombres.Size = 45;
                ParNombres.Value = clientes.Nombre;
                SqlCmd.Parameters.Add(ParNombres);

                MySqlParameter ParApellidos = new MySqlParameter();
                ParApellidos.ParameterName = "apellidos";
                ParApellidos.MySqlDbType = MySqlDbType.VarChar;
                ParApellidos.Size = 45;
                ParApellidos.Value = clientes.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

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

        public string Modificar_Cliente(D_Clientes clientes)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sjv_spModificar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDCliente = new MySqlParameter();
                ParIDCliente.ParameterName = "idcli";
                ParIDCliente.MySqlDbType = MySqlDbType.Int32;
                ParIDCliente.Value = clientes.IDCliente;
                SqlCmd.Parameters.Add(ParIDCliente);

                MySqlParameter ParIdTipoDoc = new MySqlParameter();
                ParIdTipoDoc.ParameterName = "idtdoc";
                ParIdTipoDoc.MySqlDbType = MySqlDbType.Int32;
                ParIdTipoDoc.Value = clientes.IDTipoDocumento;
                SqlCmd.Parameters.Add(ParIdTipoDoc);

                MySqlParameter ParNroDoc = new MySqlParameter();
                ParNroDoc.ParameterName = "nrodoc";
                ParNroDoc.MySqlDbType = MySqlDbType.VarChar;
                ParNroDoc.Size = 15;
                ParNroDoc.Value = clientes.NroDocumento;
                SqlCmd.Parameters.Add(ParNroDoc);

                MySqlParameter ParTelefono = new MySqlParameter();
                ParTelefono.ParameterName = "telefono";
                ParTelefono.MySqlDbType = MySqlDbType.VarChar;
                ParTelefono.Size = 15;
                ParTelefono.Value = clientes.NroTelefono;
                SqlCmd.Parameters.Add(ParTelefono);

                MySqlParameter ParDireccion = new MySqlParameter();
                ParDireccion.ParameterName = "direccion";
                ParDireccion.MySqlDbType = MySqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = clientes.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                MySqlParameter ParEmail = new MySqlParameter();
                ParEmail.ParameterName = "email";
                ParEmail.MySqlDbType = MySqlDbType.VarChar;
                ParEmail.Size = 45;
                ParEmail.Value = clientes.Email;
                SqlCmd.Parameters.Add(ParEmail);

                MySqlParameter ParNombres = new MySqlParameter();
                ParNombres.ParameterName = "nombre";
                ParNombres.MySqlDbType = MySqlDbType.VarChar;
                ParNombres.Size = 45;
                ParNombres.Value = clientes.Nombre;
                SqlCmd.Parameters.Add(ParNombres);

                MySqlParameter ParApellidos = new MySqlParameter();
                ParApellidos.ParameterName = "apellidos";
                ParApellidos.MySqlDbType = MySqlDbType.VarChar;
                ParApellidos.Size = 45;
                ParApellidos.Value = clientes.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se modifico el Registro";
            }
            catch (Exception ex5)
            {
                rpta = ex5.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
    }
}
