using gisunachweb.dbconnection;
using gisunachweb.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gisunachweb.Logica
{
    public class LEstudio
    {
        conectorpg conexion;
        public void insertarEstudio(Estudio estudio)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("INSERT INTO public.estudio(nombre, direccion, telefono) VALUES (@p1, @p2, @p3);");
            conexion.AsignarParametro("@p1", estudio.nombre);
            conexion.AsignarParametro("@p2", estudio.direccion);
            conexion.AsignarParametro("@p3", estudio.telefono);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void actualizarEstudio(Estudio estudio)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("UPDATE public.estudio SET nombre=@p2, direccion=@p3, telefono=@p4 WHERE id=@p1;");
            conexion.AsignarParametro("@p2", estudio.nombre);
            conexion.AsignarParametro("@p3", estudio.direccion);
            conexion.AsignarParametro("@p4", estudio.telefono);
            conexion.AsignarParametroEntero("@p1", estudio.id);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void eliminarEstudio(int idestudio)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("DELETE FROM public.estudio WHERE id=@p1;");
            conexion.AsignarParametroEntero("@p1", idestudio);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public Estudio obtenerEstudioID(int idiestudio)
        {
            Estudio oEstudio = new Estudio();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, nombre, direccion, telefono FROM public.estudio WHERE id=@p1;");
            conexion.AsignarParametroEntero("@p1", idiestudio);
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oEstudio = new Estudio(
                    Convert.ToInt32(datos.GetValue(0)),
                    Convert.ToString(datos.GetValue(1)),
                    Convert.ToString(datos.GetValue(2)),
                    Convert.ToString(datos.GetValue(3))
                    );
            }
            datos.Close();
            conexion.desconectar();
            return oEstudio;
        }

        public List<Estudio> listarEstudios()
        {
            Estudio oEstudio = new Estudio();
            List<Estudio> listado = new List<Estudio>();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, nombre, direccion, telefono FROM public.estudio;");
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oEstudio = new Estudio(
                    Convert.ToInt32(datos.GetValue(0)),
                    Convert.ToString(datos.GetValue(1)),
                    Convert.ToString(datos.GetValue(2)),
                    Convert.ToString(datos.GetValue(3))
                    );
                listado.Add(oEstudio);
            }
            datos.Close();
            conexion.desconectar();
            return listado;
        }
    }
}