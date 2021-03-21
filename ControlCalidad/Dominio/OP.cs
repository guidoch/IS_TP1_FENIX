using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ControlCalidadServidorDatos;

namespace Dominio
{
    public class OP
    {
        public OP(int numero, Empleado supervisor, Modelo modelo, Color color, LineaTrabajo lineaTrabajo)
        {
            Numero = numero;
            Supervisor = supervisor;
            Modelo = modelo;
            Color = color;
            Linea = lineaTrabajo;
            Hermanado = 0;
            this.Estado = Estado.EN_PROCESO;
            ListaPeriodos = new List<Periodo>() { new Periodo(0, true) };
        }

        public int Numero { get; set; }
        public Modelo Modelo { get; set; }
        public Color Color { get; set; }
        public int Hermanado { get; set; }
        public Estado Estado { get; set; }
        public LineaTrabajo Linea { get; set; }
        public Empleado Supervisor { get; set; }
        public List<Periodo> ListaPeriodos { get; set; }

        public void Pausar()
        {
            Estado = Estado.PAUSADA;
            int n = ListaPeriodos.Count - 1;
            ListaPeriodos[n].Fin = DateTime.Now;
            ListaPeriodos.Add(new Periodo(ListaPeriodos[n].Codigo + 1, false));
            ListaPeriodos[n + 1].Supervisor = ListaPeriodos[n].Supervisor; //asigno el mismo sup de calidad asi este puesa desasociarse manualmente
        }

        public void Reanudar()
        {
            Estado = Estado.EN_PROCESO;
            int n = ListaPeriodos.Count - 1;
            ListaPeriodos[n].Inicio = DateTime.Now;
        }

        public void Finalizar()
        {
            Estado = Estado.FINALIZADA;
            int n = ListaPeriodos.Count - 1;
            ListaPeriodos.RemoveAt(n);  //elimino el nuevo periodo generado automaticamente
        }

        public bool AsociarSupCalidad(Empleado supervisor)
        {
            var p = ListaPeriodos[ListaPeriodos.Count() - 1];
            if ((p.Supervisor == null || p.Supervisor == supervisor) && Estado.Equals(Estado.EN_PROCESO)) //hace falta recontrolar estado?
            {
                p.Supervisor = supervisor;
                return true;
            }
            else
                return false;
        }

        public bool Desasociar()
        {
            if (Estado != Estado.EN_PROCESO)
            {
                ListaPeriodos[ListaPeriodos.Count() - 1].Supervisor = null;
                return true;
            }
            return false;
        }

        public bool AgregarInspeccion(Inspeccion inspeccion)
        {
            if (this.Estado == Estado.EN_PROCESO)
            {
                //inspeccion.FechaYHora = RepositorioHora.Instancia.HoraActual(); //REPOOOOOOO
                inspeccion.FechaYHora = DateTime.Now;
                inspeccion.Codigo = ListaPeriodos[ListaPeriodos.Count() - 1].ListaInspeecciones.Count();
                ListaPeriodos[ListaPeriodos.Count() - 1].ListaInspeecciones.Add(inspeccion);
                return true;
            }
            else
                return false;
        }
    }
}
