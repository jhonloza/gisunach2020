using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Npgsql;

namespace gisunachweb.dbconnection
{
    public class conectorpg
    {
        private  string cadena = "Server=192.168.1.108; Database=proyectogis; User Id=postgres; Password=Jhon2020;";
        private  NpgsqlConnection conector;
        private  NpgsqlCommand comando;
        private  NpgsqlTransaction trans;
        public  void conectar()
        {
            conector = new NpgsqlConnection(cadena);
            conector.Open();
        }
        public  void desconectar()
        {
            try
            {
                if (conector.State.Equals(ConnectionState.Open))
                {
                    conector.Close();
                }
            } catch(Exception ex)
            {
                Console.WriteLine("Error al cerrar Conexion: " + ex.Message);
            }
        }
        public  void crearComandoTran(string stringSQL)
        {
            comando = new NpgsqlCommand();
            comando.Connection = conector;
            comando.CommandText = stringSQL;
            comando.CommandType = CommandType.Text;
            comando.Transaction = trans;
        }
        public  void crearComandoStringSql(string stringSQL)
        {
            comando = new NpgsqlCommand();
            comando.Connection = conector;
            comando.CommandText = stringSQL;
            comando.CommandType = CommandType.Text;
        }
        public  void ejecutarComando()
        {
            comando.ExecuteNonQuery();
        }
        public  NpgsqlDataAdapter ConstruirAdaptador()
        {
            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(comando.CommandText, conector);
            return adaptador;
        }
        public  NpgsqlDataReader EjecutarConsulta()
        {
            NpgsqlDataReader lector = comando.ExecuteReader();

            return lector;
        }
        public  void AsignarParametro(string nombreparam, string valor)
        {
            NpgsqlParameter parametro = new NpgsqlParameter();
            parametro.ParameterName = nombreparam;
            parametro.Value = valor;
            comando.Parameters.Add(parametro);
        }
        public  void AsignarParametroEntero(string nombreparam, Object valor)
        {
            NpgsqlParameter parametro = new NpgsqlParameter();
            parametro.ParameterName = nombreparam;
            parametro.DbType = DbType.Int32;
            parametro.Value = valor;
            comando.Parameters.Add(parametro);
        }

        public  void AsignarParametroDecimal(string nombreparam, Object valor)
        {
            NpgsqlParameter parametro = new NpgsqlParameter();
            parametro.ParameterName = nombreparam;
            parametro.DbType = DbType.Decimal;
            parametro.Value = valor;
            comando.Parameters.Add(parametro);
        }

        public  void AsignarParametroFecha(string nombreparam, DateTime valor)
        {
            NpgsqlParameter parametro = new NpgsqlParameter();
            parametro.ParameterName = nombreparam;
            parametro.DbType = DbType.DateTime;
            parametro.Value = valor;
            comando.Parameters.Add(parametro);
        }
        public void AsignarParametroBoolean(string nombreparam, Boolean valor)
        {
            NpgsqlParameter parametro = new NpgsqlParameter();
            parametro.ParameterName = nombreparam;
            parametro.DbType = DbType.Boolean;
            parametro.Value = valor;
            comando.Parameters.Add(parametro);
        }
        public  void AsignarParametroImagen(string nombreparam, Object valor)
        {
            NpgsqlParameter parametro = new NpgsqlParameter();
            parametro.ParameterName = nombreparam;
            parametro.DbType = DbType.Byte;
            parametro.Value = valor;
            comando.Parameters.Add(parametro);
        }
    }
}