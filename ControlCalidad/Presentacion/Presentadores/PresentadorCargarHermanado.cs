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
    class PresentadorCargarHermanado
    {
        private VistaCargarHermanado _vista;
        private BindingSource _bindingOP;
        private int _op;

        public PresentadorCargarHermanado(VistaCargarHermanado vista, int numero, BindingSource bindingOP)
        {
            this._vista = vista;
            this._op = numero;
            this._bindingOP = bindingOP;
        }

        internal void CargarHermanado(int hermanado)
        {
            if (Adaptador.CargarHermanado(hermanado, _op))
            {
                MessageBox.Show("Hermanado cargado correctamente.","Aviso");
            }
            else
            {
                MessageBox.Show("No se pudo cargar hermanado, OP finalizada.", "Aviso");
            }
            Actualizar();
            _vista.Close();
        }

        internal void Actualizar()
        {
            _bindingOP.DataSource = Adaptador.GetOP(_op);
        }
    }
}
