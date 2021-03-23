using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Aplicacion
{
    public class GestorVisualizarInformacion
    {
        public static int ContarPrimeraEnTurno(int numeroOP)
        {
            return RepositorioOP.Instancia.ContarPrimeraEnTurno(RepositorioOP.Instancia.BuscarCodigo(numeroOP));
        }

        public static int CalcularObjetivo(int numeroOP)
        {
            var turno = RepositorioTurnos.Instancia.TurnoActual();
            int hs = turno.Fin.Hour - turno.Inicio.Hour;
            if (hs < 0) hs = hs * -1;
            return RepositorioOP.Instancia.BuscarCodigo(numeroOP).Modelo.Objetivo * hs;
        }

        public static DataTable TopDefectos(int numeroOP)
        {
            return RepositorioOP.Instancia.TopDefectos(RepositorioOP.Instancia.BuscarCodigo(numeroOP));
        }

        /*//private PresentadorVisualizarInformacion _presentador;
        public OP OP { get; set; }

        public GestorVisualizarInformacion(/*PresentadorVisualizarInformacion presentador, int op)
        {
            //this._presentador = presentador;
            this.OP = RepositorioOP.Instancia.BuscarCodigo(op);
            RepositorioOP.Suscribe(Actualizar); //me suscribo para recibir aaactualizaciones del repo
        }

        private void Actualizar()
        {
            //!!_presentador.Actualizar(); //ROTO BUSCAR SOLUCION //OJO!
        }

        internal int ContarPrimeraEnTurno()
        {
            return RepositorioOP.Instancia.ContarPrimeraEnTurno(OP);
        }

        internal void Close()
        {
            RepositorioOP.Desuscribe(Actualizar);
        }

        internal int CalcularObjetivo()
        {
            var turno = RepositorioTurnos.Instancia.TurnoActual();
            int hs = turno.Fin.Hour - turno.Inicio.Hour;
            if (hs < 0) hs = hs * -1;
            return OP.Modelo.Objetivo * hs;
        }

        internal DataTable TopDefectos()
        {
            return RepositorioOP.Instancia.TopDefectos(OP);
        }*/
    }
}
