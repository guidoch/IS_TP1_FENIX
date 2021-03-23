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
    class PresentadorListaOpSupLinea
    {
        private VistaListaOP _vista;
        private AutenticarDTO _login;
        private BindingSource _bindingEmpleado;
        private BindingSource _bindingOPs;

        public PresentadorListaOpSupLinea(VistaListaOP vista, AutenticarDTO login, BindingSource empleadoBindingSource, BindingSource oPBindingSource)
        {
            this._vista = vista;
            this._login = login;
            this._bindingEmpleado = empleadoBindingSource;
            this._bindingOPs = oPBindingSource;
        }
        public void Actualizar()
        {
            _bindingEmpleado.DataSource = _login;
            _bindingOPs.DataSource = Adaptador.ListarOPs(_login.Empleado);
        }

        internal void IniciarOP()
        {
            //controlar que no haya ops sin finalizar para el sup
            if (Adaptador.ControlarOPsTodasFinalizadas(_login.Empleado))
            {
                MessageBox.Show("Abriendo ventana inicio OP", "Aviso");
                new VistaIniciarOP(_login).ShowDialog();
            }
            else
                MessageBox.Show("Existen OPs sin finalizar", "Aviso");
            Actualizar();
        }

        internal void ReanudarOP()
        {
            if (Adaptador.ReanudarOP((_bindingOPs.Current as OPDTO).Numero)) MessageBox.Show("OP reanudada", "Aviso");
            else MessageBox.Show("OP no se puede reanudar", "Aviso");
            Actualizar();
        }

        internal void VisualizarOP()
        {
            var op = (_bindingOPs.Current as OPDTO);
            new VistaVisualizarInformacion(op, _login).Show();
        }

        internal void FinalizarOP()
        {
            if (Adaptador.FinalizarOP((_bindingOPs.Current as OPDTO).Numero)) MessageBox.Show("OP finalizada", "Aviso");
            else MessageBox.Show("OP no se puede finalizar", "Aviso");
            Actualizar();
        }

        internal void PausarOP()
        {
            if (Adaptador.PausarOP((_bindingOPs.Current as OPDTO).Numero)) MessageBox.Show("OP pausada", "Aviso");
            else MessageBox.Show("OP no se puede pausar", "Aviso");
            Actualizar();
        }
    }
}
