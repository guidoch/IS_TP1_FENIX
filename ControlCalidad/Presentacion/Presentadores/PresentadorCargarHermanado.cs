using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCalidadClientePresentacion.Vistas;
using ControlCalidadClienteAccesoExterno;
using ControlCalidadClienteAccesoExterno.Entidades;
//using ControlCalidadClientePresentacion.Gestores;

namespace ControlCalidadClientePresentacion.Presentadores
{
    class PresentadorCargarHermanado
    {
        private VistaCargarHermanado _vista;
        private OP _OP;
        private BindingSource bindingOP;
        //private GestorCargarHermanado _gestor;

        public PresentadorCargarHermanado(VistaCargarHermanado vista, int numero, BindingSource bindingOP)
        {
            this._vista = vista;
            //this._gestor = new GestorCargarHermanado(this, numero);
            this._OP = Adaptador.GetOP(numero);
            this.bindingOP = bindingOP;
        }

        internal void CargarHermanado(int hermanado)
        {
            if (Adaptador.CargarHermanado(hermanado))
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
            bindingOP.DataSource = Adaptador.GetOP(_OP.Numero) as ControlCalidadClienteAccesoExterno.Entidades.OP;
        }
    }
}
