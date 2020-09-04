using gisunachweb.dbconnection;
using gisunachweb.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gisunachweb.Logica
{
    public class LGestion
    {
        conectorpg conexion;
        LPaciente logPac;
        LTrabajo logTrab;
        LEstudio logEst;
        public void insertariPaciente(InfoPaciente ipaciente)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("INSERT INTO public.infopaciente(" +
                "idpaciente, numpersonas, idtrabajo, idestudio, enfermedadc, diabetes, sobrepeso, aseguradoiess, nombrecemer, celularemer, correoemer) " +
                "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11);");
            conexion.AsignarParametroEntero("@p1", ipaciente.paciente.id);
            conexion.AsignarParametroDecimal("@p2", ipaciente.numpersonas);
            conexion.AsignarParametroEntero("@p3", ipaciente.trabajo.id);
            conexion.AsignarParametroEntero("@p4", ipaciente.estudio.id);
            conexion.AsignarParametro("@p5", ipaciente.enfermedadc);
            conexion.AsignarParametro("@p6", ipaciente.diabetes);
            conexion.AsignarParametro("@p7", ipaciente.sobrepeso);
            conexion.AsignarParametro("@p8", ipaciente.aseguradoiess);
            conexion.AsignarParametro("@p9", ipaciente.nombrecemer);
            conexion.AsignarParametro("@p10", ipaciente.celularemer);
            conexion.AsignarParametro("@p11", ipaciente.correoemer);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void actualizariPaciente(InfoPaciente ipaciente)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("UPDATE public.infopaciente SET idpaciente=@p1, numpersonas=@p2, idtrabajo=@p3, idestudio=@p4, enfermedadc=@p5, diabetes=@p6, sobrepeso=@p7, aseguradoiess=@p8, nombrecemer=@p9, celularemer=@p10, correoemer=@p11" +
                " WHERE id=@p12;");
            conexion.AsignarParametroEntero("@p1", ipaciente.paciente.id);
            conexion.AsignarParametroDecimal("@p2", ipaciente.numpersonas);
            conexion.AsignarParametroEntero("@p3", ipaciente.trabajo.id);
            conexion.AsignarParametroEntero("@p4", ipaciente.estudio.id);
            conexion.AsignarParametro("@p5", ipaciente.enfermedadc);
            conexion.AsignarParametro("@p6", ipaciente.diabetes);
            conexion.AsignarParametro("@p7", ipaciente.sobrepeso);
            conexion.AsignarParametro("@p8", ipaciente.aseguradoiess);
            conexion.AsignarParametro("@p9", ipaciente.nombrecemer);
            conexion.AsignarParametro("@p10", ipaciente.celularemer);
            conexion.AsignarParametro("@p11", ipaciente.correoemer);
            conexion.AsignarParametroEntero("@p12", ipaciente.id);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public void eliminariPaciente(int idiPaciente)
        {
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("DELETE FROM public.infopaciente WHERE id =@p1;");
            conexion.AsignarParametroEntero("@p1", idiPaciente);
            conexion.ejecutarComando();
            conexion.desconectar();
        }
        public InfoPaciente obteneriPacienteID(int idiPaciente)
        {
            InfoPaciente oPaciente = new InfoPaciente();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, idpaciente, numpersonas, idtrabajo, idestudio, enfermedadc, diabetes, sobrepeso, aseguradoiess, nombrecemer, celularemer, correoemer FROM public.infopaciente WHERE id=@p1;");
            conexion.AsignarParametroEntero("@p1", idiPaciente);
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                Paciente np = new Paciente();
                np = logPac.obtenerPacienteID(Convert.ToInt32(datos.GetValue(1)));
                Trabajo nt = new Trabajo();
                nt = logTrab.obtenerTrabajoID(Convert.ToInt32(datos.GetValue(3)));
                Estudio ne = new Estudio();
                ne = logEst.obtenerEstudioID(Convert.ToInt32(datos.GetValue(4)));
                oPaciente = new InfoPaciente(
                    Convert.ToInt32(datos.GetValue(0)),
                    np,
                    Convert.ToInt32(datos.GetValue(2)),
                    nt,
                    ne,
                    Convert.ToString(datos.GetValue(5)),
                    Convert.ToString(datos.GetValue(6)),
                    Convert.ToString(datos.GetValue(7)),
                    Convert.ToString(datos.GetValue(8)),
                    Convert.ToString(datos.GetValue(9)),
                    Convert.ToString(datos.GetValue(10)),
                    Convert.ToString(datos.GetValue(11))
                    );
            }
            datos.Close();
            conexion.desconectar();
            return oPaciente;
        }

        public List<InfoPaciente> listariPacientes()
        {
            InfoPaciente oPaciente = new InfoPaciente();
            List<InfoPaciente> listado = new List<InfoPaciente>();
            conexion = new conectorpg();
            conexion.conectar();
            conexion.crearComandoStringSql("SELECT id, idpaciente, numpersonas, idtrabajo, idestudio, enfermedadc, diabetes, sobrepeso, aseguradoiess, nombrecemer, celularemer, correoemer FROM public.infopaciente;");
            NpgsqlDataReader datos = conexion.EjecutarConsulta();
            while (datos.Read())
            {
                Paciente np = new Paciente();
                np = logPac.obtenerPacienteID(Convert.ToInt32(datos.GetValue(1)));
                Trabajo nt = new Trabajo();
                nt = logTrab.obtenerTrabajoID(Convert.ToInt32(datos.GetValue(3)));
                Estudio ne = new Estudio();
                ne = logEst.obtenerEstudioID(Convert.ToInt32(datos.GetValue(4)));
                oPaciente = new InfoPaciente(
                    Convert.ToInt32(datos.GetValue(0)),
                    np,
                    Convert.ToInt32(datos.GetValue(2)),
                    nt,
                    ne,
                    Convert.ToString(datos.GetValue(5)),
                    Convert.ToString(datos.GetValue(6)),
                    Convert.ToString(datos.GetValue(7)),
                    Convert.ToString(datos.GetValue(8)),
                    Convert.ToString(datos.GetValue(9)),
                    Convert.ToString(datos.GetValue(10)),
                    Convert.ToString(datos.GetValue(11))
                    );
                listado.Add(oPaciente);
            }
            datos.Close();
            conexion.desconectar();
            return listado;
        }
    }
}