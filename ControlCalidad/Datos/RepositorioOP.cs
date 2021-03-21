using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepositorioOP : IRepositorio<OP>
    {
        private readonly static RepositorioOP _instance = new RepositorioOP();
        private static event Action onOPchange;
        public static RepositorioOP Instancia
        {
            get
            {
                return _instance;
            }
        }
        public List<OP> _ops;
        private RepositorioOP()
        {
            _ops = new List<OP>() { new OP(0,
                RepositorioEmpleados.Instancia._empleados[1],
                RepositorioModelos.Instancia._modelos[0],
                RepositorioColores.Instancia._colores[0],
                RepositorioLineasDeTrabajo.Instancia._lineas[0])};
        }

        public static void Suscribe(Action actualizar)
        {
            onOPchange += actualizar;
        }
        public static void Desuscribe(Action actualizar)
        {
            onOPchange -= actualizar;
        }

        public OP BuscarCodigo(int codigo)
        {
            return _ops.Find(item => item.Numero == codigo);
        }
        public void Guardar(OP objeto)
        {
            _ops.Add(objeto);
            onOPchange?.Invoke();
        }
        public bool GuardarSeguro(OP objeto)
        {
            if (VerificarLineaLibre(objeto.Linea.Numero))
            {
                _ops.Add(objeto);
                onOPchange?.Invoke();
                return true;
            }
                else return false;
        }
        public OP VerificarExistencia(int codigo)
        {
            return _ops.Find(item => item.Numero == codigo);
        }
        public List<OP> BuscarSupervisorLinea(Empleado supervisor)
        {
            var listaOP = new List<OP>();
            foreach (var op in _ops)
            {
                if (op.Supervisor.Codigo.Equals(supervisor.Codigo)) listaOP.Add(op);
            }
            return listaOP;
        }

        public bool SupervisorDisponible(Empleado supervisor)
        {
            foreach (var op in _ops)
            {
                if (op.ListaPeriodos[op.ListaPeriodos.Count() - 1].Supervisor == supervisor)
                {
                    return false;
                }
            }
            return true;
        }

        public bool TodasFinalizadas(Empleado supervisor)
        {
            foreach (var op in _ops)
            {
                if (op.Supervisor.Equals(supervisor) && !op.Estado.Equals(Estado.FINALIZADA))
                {
                    return false;
                }
            }
            return true;
        }

        public bool VerificarLineaLibre(int linea)
        {
            foreach (var op in _ops)
            {
                if (op.Linea.Numero.Equals(linea) && !op.Estado.Equals(Estado.FINALIZADA))
                {
                    return false;
                }
            }
            return true;
        }

        public List<LineaTrabajo> ListarLineasLibres()
        {
            var lista = new List<LineaTrabajo>(RepositorioLineasDeTrabajo.Instancia._lineas);
            foreach (var op in _ops)
            {
                if (!op.Estado.Equals(Estado.FINALIZADA))
                {
                    lista.Remove(op.Linea);
                }
            }
            return lista;
        }
        public int ContarPrimeraEnTurno(OP op)
        {
            var horaActual = DateTime.Now;
            var turno = RepositorioTurnos.Instancia.TurnoActual();
            var horaMax = new DateTime(horaActual.Year, horaActual.Month, horaActual.Day, turno.Fin.Hour, turno.Fin.Minute, turno.Fin.Second);
            var horaMin = new DateTime(horaActual.Year, horaActual.Month, horaActual.Day, turno.Inicio.Hour, turno.Inicio.Minute, turno.Inicio.Second);

            int primera = 0;

            foreach (var p in op.ListaPeriodos)
            {
                foreach (var i in p.ListaInspeecciones)
                {
                    if (DateTime.Compare(i.FechaYHora, horaMin) >= 0 && DateTime.Compare(i.FechaYHora, horaMax) <= 0 && i.ListaDefectos.Count == 0)
                    {
                        primera += 1;
                    }
                }
            }
            return primera;
        }
        public DataTable TopDefectos(OP op)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Tipo Defecto");
            dt.Columns.Add("Cantidad", typeof(int));

            //var cuenta = new List<int>();

            var horaActual = DateTime.Now;
            var turno = RepositorioTurnos.Instancia.TurnoActual();
            var horaMax = new DateTime(horaActual.Year, horaActual.Month, horaActual.Day, turno.Fin.Hour, turno.Fin.Minute, turno.Fin.Second);
            var horaMin = new DateTime(horaActual.Year, horaActual.Month, horaActual.Day, turno.Inicio.Hour, turno.Inicio.Minute, turno.Inicio.Second);

            foreach (TipoDefecto defecto in RepositorioTiposDefecto.Instancia._tiposdefecto)
            {
                dt.Rows.Add(new object[] { defecto.Codigo, defecto.Descripcion, 0 });
            }

            foreach (var p in op.ListaPeriodos)
            {
                foreach (var i in p.ListaInspeecciones)
                {
                    if (DateTime.Compare(i.FechaYHora, horaMin) >= 0 && DateTime.Compare(i.FechaYHora, horaMax) <= 0 && i.ListaDefectos.Count != 0)
                    {
                        foreach (var d in i.ListaDefectos)
                        {
                            var n = Convert.ToInt32(dt.Rows[d.TipoDefecto.Codigo]["Cantidad"]);
                            dt.Rows[d.TipoDefecto.Codigo]["Cantidad"] = n + 1;
                            //cuenta[d.TipoDefecto.Codigo] += 1;
                        }
                    }
                }
            }

            return dt;
        }
        public void Actualizar(OP op)
        {
            // Aqui se deberia actualizar la op en la BBDD
            onOPchange?.Invoke();
        }
    }
}
