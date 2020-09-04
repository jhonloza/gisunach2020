using gisunachweb.dbconnection;
using gisunachweb.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gisunachweb.Logica
{
    public class LTrabajo
    {
        conectorpg conexion;
        public void insertarTrabajo(Trabajo trabajo)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("INSERT INTO public.trabajo(nombre, direccion, telefono) VALUES (@p2, @p3, @p4);");
            conexion.AsignarParametro("@p2", trabajo.nombre);
            conexion.AsignarParametro("@p3", trabajo.direccion);
            conexion.AsignarParametro("@p4", trabajo.telefono);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void actualizarTrabajo(Trabajo trabajo)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("UPDATE public.trabajo SET nombre=@p2, direccion=@p3, telefono=@p4 WHERE id=@p1;");
            conexion.AsignarParametro("@p2", trabajo.nombre);
            conexion.AsignarParametro("@p3", trabajo.direccion);
            conexion.AsignarParametro("@p4", trabajo.telefono);
            conexion.AsignarParametroEntero("@p1", trabajo.id);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void eliminarTrabajo(int idTrabajo)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("DELETE FROM public.trabajo WHERE id=@p1;");
            conexion.AsignarParametroEntero("@p1", idTrabajo);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public Trabajo obtenerTrabajoID(int idiTrabajo)
        {
            Trabajo oTrabajo = new Trabajo();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, nombre, direccion, telefono FROM public.trabajo WHERE id=@p1;");
            conexion.AsignarParametroEntero("@p1", idiTrabajo);
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oTrabajo = new Trabajo(
                    Convert.ToInt32(datos.GetValue(0)),
                    Convert.ToString(datos.GetValue(1)),
                    Convert.ToString(datos.GetValue(2)),
                    Convert.ToString(datos.GetValue(3))
                    );
            }
            datos.Close();
            conexion.desconectar();
            return oTrabajo;
        }

        public List<Trabajo> listarTrabajo()
        {
            Trabajo oTrabajo = new Trabajo();
            List<Trabajo> listado = new List<Trabajo>();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, nombre, direccion, telefono FROM public.trabajo;");
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oTrabajo = new Trabajo(
                    Convert.ToInt32(datos.GetValue(0)),
                    Convert.ToString(datos.GetValue(1)),
                    Convert.ToString(datos.GetValue(2)),
                    Convert.ToString(datos.GetValue(3))
                    );
                listado.Add(oTrabajo);
            }
            datos.Close();
            conexion.desconectar();
            return listado;
        }
    }
}