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
    class PresentadorIniciarOP
    {
        private VistaIniciarOP _vista;
        private AutenticarDTO _login;

        private BindingSource _bindingLogin;
        private BindingSource _bindingModelo;
        private BindingSource _bindingColor;
        private BindingSource _bindingLinea;

        public PresentadorIniciarOP(VistaIniciarOP vista, AutenticarDTO login, BindingSource loginBindingSource, BindingSource modeloBindingSource, BindingSource colorBindingSource, BindingSource lineaTrabajoBindingSource) //: this(vista, supervisor)
        {
            this._login = login;
            this._vista = vista;

            this._bindingLogin = loginBindingSource;
            this._bindingModelo = modeloBindingSource;
            this._bindingColor = colorBindingSource;
            this._bindingLinea = lineaTrabajoBindingSource;
        }

        internal void IniciarOP(int numero, int linea, int modelo, int color)
        {
            //controlar que la linea este libre
            if (Adaptador.IniciarOP(numero, linea, modelo, color, _login.Empleado)) MessageBox.Show("OP creada", "Aviso");
            else MessageBox.Show("Linea ocupada", "Aviso");
            Actualizar();
        }

        public void Actualizar()
        {
            _bindingLogin.DataSource = _login;
            _bindingModelo.DataSource = Adaptador.GetModelos();
            _bindingColor.DataSource = Adaptador.GetColores();
            _bindingLinea.DataSource = Adaptador.GetLineasLibres();
        }
    }
}
