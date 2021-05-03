using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class D_Usuarios
    {
        //Variables
        private int _IdUsuario;
        private int _IdTipoDocumento;
        private string _NroDocumento;
        private string _Telefono;
        private string _Nombre;
        private string _Apellidos;
        private int _IdCargo;
        private string _nombreCargo;
        private string _descripcionCargo;
        private string _Direccion;
        private string _Email;
        private string _Username;
        private string _Password;

        //Propiedades
        public int idUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
        public int idTipoDocumento
        {
            get {return _IdTipoDocumento; }
            set { _IdTipoDocumento = value; }
        }
        public string nroDocumento
        {
            get { return _NroDocumento; }
            set { _NroDocumento = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        public int idCargo
        {
            get { return _IdCargo; }
            set { _IdCargo = value; }
        }

        public string nombreCargo
        {
            get { return _nombreCargo; }
            set { _nombreCargo = value; }
        }
        public string descripcionCargo
        {
            get { return _descripcionCargo; }
            set { _descripcionCargo = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        //Constructores
        public D_Usuarios()
        {

        }
        public D_Usuarios( int idusuario,
                         int idtipodocumento,
                         string nrodocumento,
                         string telefono,
                         string nombre,
                         string apellidos,
                         int idcargo,
                         string direccion,
                         string email,
                         string username,
                         string password
            )
        {
            this.idUsuario = idusuario;
            this.idTipoDocumento = idtipodocumento;
            this.nroDocumento = nrodocumento;
            this.Telefono = telefono;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.idCargo = idcargo;
            this.Direccion = direccion;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }

        //Login
        public DataTable Login(D_Usuarios Usuario)
        {
            DataTable DtResultado = new DataTable("UsuarioLogIn");
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = mySqlConnection;
                SqlCmd.CommandText = "sjv_spLogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParUsuario = new MySqlParameter();
                ParUsuario.ParameterName = "username";
                ParUsuario.MySqlDbType = MySqlDbType.VarChar;
                ParUsuario.Size = 16;
                ParUsuario.Value = Usuario.Username;
                SqlCmd.Parameters.Add(ParUsuario);

                MySqlParameter ParPassword = new MySqlParameter();
                ParPassword.ParameterName = "passwrd";
                ParPassword.MySqlDbType = MySqlDbType.VarChar;
                ParPassword.Size = 16;
                ParPassword.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassword);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
            
        }

        public DataTable BusquedaSimple_Usuario()
        {
            DataTable DtResultado = new DataTable("ListadoUsuarios");
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = mySqlConnection;
                sqlCmd.CommandText = "sjv_spMostrar_Usuarios";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter mySqlData = new MySqlDataAdapter(sqlCmd);
                mySqlData.Fill(DtResultado);

            }
            catch(Exception ex1)
            {
                DtResultado = null;
                
            }
            return DtResultado;
        }

        public DataTable BusquedaSimple_Cargo_Usuario()
        {
            DataTable DtResultado = new DataTable("ListadoCargos");
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = mySqlConnection;
                sqlCmd.CommandText = "sjv_spMostrar_CargoUsuario";
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

        public string Insertar_Usuario(D_Usuarios Usuario)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sjv_spInsertar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIdTipoDoc = new MySqlParameter();
                ParIdTipoDoc.ParameterName = "idtipodoc";
                ParIdTipoDoc.MySqlDbType = MySqlDbType.Int32;
                ParIdTipoDoc.Value = Usuario.idTipoDocumento;
                SqlCmd.Parameters.Add(ParIdTipoDoc);

                MySqlParameter ParNroDoc = new MySqlParameter();
                ParNroDoc.ParameterName = "ndoc";
                ParNroDoc.MySqlDbType = MySqlDbType.VarChar;
                ParNroDoc.Size = 12;
                ParNroDoc.Value = Usuario.nroDocumento;
                SqlCmd.Parameters.Add(ParNroDoc);

                MySqlParameter ParTelefono = new MySqlParameter();
                ParTelefono.ParameterName = "telef";
                ParTelefono.MySqlDbType = MySqlDbType.VarChar;
                ParTelefono.Size = 15;
                ParTelefono.Value = Usuario.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                MySqlParameter ParIdCargo = new MySqlParameter();
                ParIdCargo.ParameterName = "idcargo";
                ParIdCargo.MySqlDbType = MySqlDbType.Int32;
                ParIdCargo.Value = Usuario.idCargo;
                SqlCmd.Parameters.Add(ParIdCargo);

                MySqlParameter ParDireccion = new MySqlParameter();
                ParDireccion.ParameterName = "direccion";
                ParDireccion.MySqlDbType = MySqlDbType.VarChar;
                ParDireccion.Size = 150;
                ParDireccion.Value = Usuario.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);
                
                MySqlParameter ParEmail = new MySqlParameter();
                ParEmail.ParameterName = "email";
                ParEmail.MySqlDbType = MySqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Usuario.Email;
                SqlCmd.Parameters.Add(ParEmail);

                MySqlParameter ParUsuario = new MySqlParameter();
                ParUsuario.ParameterName = "usuario";
                ParUsuario.MySqlDbType = MySqlDbType.VarChar;
                ParUsuario.Size = 16;
                ParUsuario.Value = Usuario.Username;
                SqlCmd.Parameters.Add(ParUsuario);

                MySqlParameter ParPasswrd = new MySqlParameter();
                ParPasswrd.ParameterName = "passwrd";
                ParPasswrd.MySqlDbType = MySqlDbType.VarChar;
                ParPasswrd.Size = 16;
                ParPasswrd.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPasswrd);

                MySqlParameter ParNombres = new MySqlParameter();
                ParNombres.ParameterName = "nombres";
                ParNombres.MySqlDbType = MySqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(ParNombres);

                MySqlParameter ParApellidos = new MySqlParameter();
                ParApellidos.ParameterName = "apellidos";
                ParApellidos.MySqlDbType = MySqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Usuario.Apellidos;
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
        public string Modificar_Usuario(D_Usuarios Usuario)
        {
            string rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sjv_spModificar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDUsuario = new MySqlParameter();
                ParIDUsuario.ParameterName = "idusuario";
                ParIDUsuario.MySqlDbType = MySqlDbType.Int32;
                ParIDUsuario.Value = Usuario.idTipoDocumento;
                SqlCmd.Parameters.Add(ParIDUsuario);

                MySqlParameter ParIdTipoDoc = new MySqlParameter();
                ParIdTipoDoc.ParameterName = "idtipodoc";
                ParIdTipoDoc.MySqlDbType = MySqlDbType.Int32;
                ParIdTipoDoc.Value = Usuario.idTipoDocumento;
                SqlCmd.Parameters.Add(ParIdTipoDoc);

                MySqlParameter ParNroDoc = new MySqlParameter();
                ParNroDoc.ParameterName = "ndoc";
                ParNroDoc.MySqlDbType = MySqlDbType.VarChar;
                ParNroDoc.Size = 12;
                ParNroDoc.Value = Usuario.nroDocumento;
                SqlCmd.Parameters.Add(ParNroDoc);

                MySqlParameter ParTelefono = new MySqlParameter();
                ParTelefono.ParameterName = "telef";
                ParTelefono.MySqlDbType = MySqlDbType.VarChar;
                ParTelefono.Size = 15;
                ParTelefono.Value = Usuario.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                MySqlParameter ParIdCargo = new MySqlParameter();
                ParIdCargo.ParameterName = "idcargo";
                ParIdCargo.MySqlDbType = MySqlDbType.Int32;
                ParIdCargo.Value = Usuario.idCargo;
                SqlCmd.Parameters.Add(ParIdCargo);

                MySqlParameter ParDireccion = new MySqlParameter();
                ParDireccion.ParameterName = "direccion";
                ParDireccion.MySqlDbType = MySqlDbType.VarChar;
                ParDireccion.Size = 150;
                ParDireccion.Value = Usuario.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                MySqlParameter ParEmail = new MySqlParameter();
                ParEmail.ParameterName = "email";
                ParEmail.MySqlDbType = MySqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Usuario.Email;
                SqlCmd.Parameters.Add(ParEmail);

                MySqlParameter ParUsuario = new MySqlParameter();
                ParUsuario.ParameterName = "usuario";
                ParUsuario.MySqlDbType = MySqlDbType.VarChar;
                ParUsuario.Size = 16;
                ParUsuario.Value = Usuario.Username;
                SqlCmd.Parameters.Add(ParUsuario);

                MySqlParameter ParPasswrd = new MySqlParameter();
                ParPasswrd.ParameterName = "passwrd";
                ParPasswrd.MySqlDbType = MySqlDbType.VarChar;
                ParPasswrd.Size = 16;
                ParPasswrd.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPasswrd);

                MySqlParameter ParNombres = new MySqlParameter();
                ParNombres.ParameterName = "nombres";
                ParNombres.MySqlDbType = MySqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(ParNombres);

                MySqlParameter ParApellidos = new MySqlParameter();
                ParApellidos.ParameterName = "apellidos";
                ParApellidos.MySqlDbType = MySqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Usuario.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

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

        public string Insertar_CargoUsuario(D_Usuarios usuarios)
        {
            string rpta = "";
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                mySqlConnection.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = mySqlConnection;
                SqlCmd.CommandText = "sjv_spInsertar_CargoUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParNombre = new MySqlParameter();
                ParNombre.ParameterName = "nombre";
                ParNombre.MySqlDbType = MySqlDbType.VarChar;
                ParNombre.Size = 45;
                ParNombre.Value = usuarios.nombreCargo;
                SqlCmd.Parameters.Add(ParNombre);

                MySqlParameter ParDescripcion = new MySqlParameter();
                ParDescripcion.ParameterName = "descripcion";
                ParDescripcion.MySqlDbType = MySqlDbType.VarChar;
                ParDescripcion.Size = 150;
                ParDescripcion.Value = usuarios.descripcionCargo;
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

        public string Modificar_CargoUsuario(D_Usuarios usuarios)
        {
            string rpta = "";
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = Conexion.Cn;
                mySqlConnection.Open();
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = mySqlConnection;
                SqlCmd.CommandText = "sjv_spModificar_CargoUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIDTDoc = new MySqlParameter();
                ParIDTDoc.ParameterName = "idtdoc";
                ParIDTDoc.MySqlDbType = MySqlDbType.Int32;
                ParIDTDoc.Value = usuarios.idCargo;
                SqlCmd.Parameters.Add(ParIDTDoc);

                MySqlParameter ParNombre = new MySqlParameter();
                ParNombre.ParameterName = "nombre";
                ParNombre.MySqlDbType = MySqlDbType.VarChar;
                ParNombre.Size = 45;
                ParNombre.Value = usuarios.nombreCargo;
                SqlCmd.Parameters.Add(ParNombre);

                MySqlParameter ParDescripcion = new MySqlParameter();
                ParDescripcion.ParameterName = "descripcion";
                ParDescripcion.MySqlDbType = MySqlDbType.VarChar;
                ParDescripcion.Size = 150;
                ParDescripcion.Value = usuarios.descripcionCargo;
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
