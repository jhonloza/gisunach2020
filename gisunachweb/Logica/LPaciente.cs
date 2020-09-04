using gisunachweb.dbconnection;
using gisunachweb.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;
using System.Windows.Media;

namespace gisunachweb.Logica
{
    public class LPaciente
    {
        conectorpg conexion;
        public void insertarPaciente(Paciente paciente)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("INSERT INTO public.pacientes(" +
                "geom, x, y, nombres, apellidos, fechanac, direccion, cedula, telfconv, celular, correoelec, sexo) " +
                "VALUES(ST_GeomFromText(@p1, 32717), @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13); ");
            conexion.AsignarParametro("@p1", paciente.geometry);
            conexion.AsignarParametroDecimal("@p3", paciente.x);
            conexion.AsignarParametroDecimal("@p4", paciente.y);
            conexion.AsignarParametro("@p5", paciente.nombres);
            conexion.AsignarParametro("@p6", paciente.apellidos);
            conexion.AsignarParametroFecha("@p7", paciente.fechanac);
            conexion.AsignarParametro("@p8", paciente.direccion);
            conexion.AsignarParametro("@p9", paciente.cedula);
            conexion.AsignarParametro("@p10", paciente.telfconv);
            conexion.AsignarParametro("@p11", paciente.celular);
            conexion.AsignarParametro("@p12", paciente.correoelec);
            conexion.AsignarParametro("@p13", paciente.sexo);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void actualizarPaciente(Paciente paciente)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("UPDATE public.pacientes SET x=@p1, y=@p2, nombres=@pp3, apellidos=@p4, fechanac=@p5, direccion=@p6, cedula=@p7, telfconv=@p8, celular=@p9, correoelec=@p10, sexo=@p11 WHERE id= @p12;");
            conexion.AsignarParametroDecimal("@p1", paciente.x);
            conexion.AsignarParametroDecimal("@p2", paciente.y);
            conexion.AsignarParametro("@p3", paciente.nombres);
            conexion.AsignarParametro("@p4", paciente.apellidos);
            conexion.AsignarParametroFecha("@p5", paciente.fechanac);
            conexion.AsignarParametro("@p6", paciente.direccion);
            conexion.AsignarParametro("@p7", paciente.cedula);
            conexion.AsignarParametro("@p8", paciente.telfconv);
            conexion.AsignarParametro("@p9", paciente.celular);
            conexion.AsignarParametro("@p10", paciente.correoelec);
            conexion.AsignarParametro("@p11", paciente.sexo);
            conexion.AsignarParametroEntero("@p12", paciente.id);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void eliminarPaciente(int idPaciente)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("DELETE FROM public.pacientes WHERE id=@p1;");
            conexion.AsignarParametroEntero("@p1", idPaciente);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public Paciente obtenerPacienteID(int idPaciente)
        {
            Paciente oPaciente = new Paciente();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, ST_GeometryType(geom), x, y, nombres, apellidos, fechanac, direccion, cedula, telfconv, celular, correoelec, sexo FROM public.pacientes WHERE id= @id ;");
            conexion.AsignarParametroEntero("@id", idPaciente);
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oPaciente = new Paciente();
                oPaciente.id = Convert.ToInt32(datos.GetValue(0));
                oPaciente.geometry = Convert.ToString(datos.GetValue(1));
                oPaciente.x = Convert.ToDouble(datos.GetValue(2));
                oPaciente.y = Convert.ToDouble(datos.GetValue(3));
                oPaciente.nombres = Convert.ToString(datos.GetValue(4));
                oPaciente.apellidos = Convert.ToString(datos.GetValue(5));
                oPaciente.fechanac = Convert.ToDateTime(datos.GetValue(6));
                oPaciente.direccion = Convert.ToString(datos.GetValue(7));
                oPaciente.cedula = Convert.ToString(datos.GetValue(8));
                oPaciente.telfconv = Convert.ToString(datos.GetValue(9));
                oPaciente.celular = Convert.ToString(datos.GetValue(10));
                oPaciente.correoelec = Convert.ToString(datos.GetValue(11));
                oPaciente.sexo = Convert.ToString(datos.GetValue(12));
            }
            datos.Close();
            conexion.desconectar();
            return oPaciente;
        }

        public List<Paciente> listarPacientes()
        {
            Paciente oPaciente = new Paciente();
            List<Paciente> listado = new List<Paciente>();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, ST_GeometryType(geom), x, y, nombres, apellidos, fechanac, direccion, cedula, telfconv, celular, correoelec, sexo FROM public.pacientes;");
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                oPaciente = new Paciente();
                oPaciente.id = Convert.ToInt32(datos.GetValue(0));
                oPaciente.geometry = Convert.ToString(datos.GetValue(1));
                oPaciente.x = Convert.ToDouble(datos.GetValue(2));
                oPaciente.y = Convert.ToDouble(datos.GetValue(3));
                oPaciente.nombres = Convert.ToString(datos.GetValue(4));
                oPaciente.apellidos = Convert.ToString(datos.GetValue(5));
                oPaciente.fechanac = Convert.ToDateTime(datos.GetValue(6));
                oPaciente.direccion = Convert.ToString(datos.GetValue(7));
                oPaciente.cedula = Convert.ToString(datos.GetValue(8));
                oPaciente.telfconv = Convert.ToString(datos.GetValue(9));
                oPaciente.celular = Convert.ToString(datos.GetValue(10));
                oPaciente.correoelec = Convert.ToString(datos.GetValue(11));
                oPaciente.sexo = Convert.ToString(datos.GetValue(12));
                listado.Add(oPaciente);
            }
            datos.Close();
            conexion.desconectar();
            return listado;
        }
    }
}