using AccesoExterno;
using AccesoExterno.ReferenciaServicio;
using Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Presentadores
{
    class PresentadorVisualizarInformacion
    {
        private VistaVisualizarInformacion _vista;
        private BindingSource _bindingOP;

        private OPDTO _op;

        public PresentadorVisualizarInformacion(VistaVisualizarInformacion vista, OPDTO op, BindingSource bindingOP)
        {
            this._vista = vista;
            this._op = op;
            this._bindingOP = bindingOP;
        }

        internal void Actualizar()
        {
            _bindingOP.DataSource = null;
            _bindingOP.DataSource = _op;
            _vista.Actualizar(Adaptador.ContarPrimeraEnTurno(_op.Numero), Adaptador.CalcularObjetivo(_op.Numero), Adaptador.TopDefectos(_op.Numero));
        }

        internal void Close()
        {
            //Adaptador.Close();
        }
    }
}
