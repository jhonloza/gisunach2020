using gisunachweb.dbconnection;
using gisunachweb.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace gisunachweb.Logica
{
    public class LUsuario
    {
        conectorpg conexion;
        public void insertarUsuario(Usuario usuario)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("INSERT INTO public.usuario (usuario, pass, nombres, apellidos, fechanacimiento, cedula, telefono) " +
                "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7);");
            conexion.AsignarParametro("@p1", usuario.usuario);
            conexion.AsignarParametro("@p2", usuario.pass);
            conexion.AsignarParametro("@p3", usuario.nombres);
            conexion.AsignarParametro("@p4", usuario.apellidos);
            conexion.AsignarParametroFecha("@p5", usuario.fechanacimiento);
            conexion.AsignarParametro("@p6", usuario.cedula);
            conexion.AsignarParametro("@p7", usuario.telefono);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void actualizarUsuario(Usuario usuario)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("UPDATE public.usuario SET usuario= @p1, pass= @p2, nombres= @p3, apellidos= @p4, fechanacimiento= @p5, cedula= @p6, telefono= @p7 WHERE id= @p8;");
            conexion.AsignarParametro("@p1", usuario.usuario);
            conexion.AsignarParametro("@p2", usuario.pass);
            conexion.AsignarParametro("@p3", usuario.nombres);
            conexion.AsignarParametro("@p4", usuario.apellidos);
            conexion.AsignarParametroFecha("@p5", usuario.fechanacimiento);
            conexion.AsignarParametro("@p6", usuario.cedula);
            conexion.AsignarParametro("@p7", usuario.telefono);
            conexion.AsignarParametroEntero("@p8", usuario.id);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void eliminarUsuario(int idUsuario)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("DELETE FROM public.usuario WHERE id= @p1;");
            conexion.AsignarParametroEntero("@p1", idUsuario);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public Usuario obtenerUsuarioID(int idUsuario)
        {
            Usuario oUsuario = new Usuario();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, usuario, pass, nombres, apellidos, fechanacimiento, cedula, telefono FROM public.usuario WHERE id= @id ;");
            conexion.AsignarParametroEntero("@id", idUsuario);
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oUsuario = new Usuario(
                    Convert.ToInt32(datos.GetValue(0)), 
                    Convert.ToString(datos.GetValue(1)),
                    Convert.ToString(datos.GetValue(2)),
                    Convert.ToString(datos.GetValue(3)),
                    Convert.ToString(datos.GetValue(4)),
                    Convert.ToDateTime(datos.GetValue(5)),
                    Convert.ToString(datos.GetValue(6)),
                    Convert.ToString(datos.GetValue(7))
                    );
            }
            datos.Close();
            conexion.desconectar();
            return oUsuario;
        }
        
        public List<Usuario> listarUsuarios()
        {
            Usuario oUsuario = new Usuario();
            List<Usuario> listado = new List<Usuario>();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, usuario, pass, nombres, apellidos, fechanacimiento, cedula, telefono FROM public.usuario;");
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oUsuario = new Usuario(
                    Convert.ToInt32(datos.GetValue(0)),
                    Convert.ToString(datos.GetValue(1)),
                    Convert.ToString(datos.GetValue(2)),
                    Convert.ToString(datos.GetValue(3)),
                    Convert.ToString(datos.GetValue(4)),
                    Convert.ToDateTime(datos.GetValue(5)),
                    Convert.ToString(datos.GetValue(6)),
                    Convert.ToString(datos.GetValue(7))
                    );
                listado.Add(oUsuario);
            }
            datos.Close();
            conexion.desconectar();
            return listado;
        }
        public Usuario obtenerUsuario(string user, string pass)
        {
            Usuario oUsuario = new Usuario();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, usuario, pass, nombres, apellidos, fechanacimiento, cedula, telefono FROM public.usuario WHERE usuario= @usr AND pass= @pss ;");
            conexion.AsignarParametro("@usr", user);
            conexion.AsignarParametro("@pss", pass);
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oUsuario = new Usuario(
                    Convert.ToInt32(datos.GetValue(0)),
                    Convert.ToString(datos.GetValue(1)),
                    Convert.ToString(datos.GetValue(2)),
                    Convert.ToString(datos.GetValue(3)),
                    Convert.ToString(datos.GetValue(4)),
                    Convert.ToDateTime(datos.GetValue(5)),
                    Convert.ToString(datos.GetValue(6)),
                    Convert.ToString(datos.GetValue(7))
                    );
            }
            datos.Close();
            conexion.desconectar();
            return oUsuario;
        }
    }
}