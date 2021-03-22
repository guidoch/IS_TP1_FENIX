using AccesoExterno;
using AccesoExterno.ReferenciaServicio;
using Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Presentadores
{
    class PresentadorPrincipal
    {
        private VistaPrincipal _vista;
        private AutenticarDTO _login;

        public PresentadorPrincipal(VistaPrincipal vista, AutenticarDTO login)
        {
            this._vista = vista;
            this._login = login;
        }

        public void CerrarSesion()
        {
            Adaptador.CerrarSesion(_login.Sesion); //deberiamos recibir bool, no implementado
        }

        public string Actualziar()
        {
            _vista.Empleado = _login.Nombre;
            return _login.Cargo;
        }

        public void IniciarVistaListaOPSupCalidad()
        {
            if ((_vista.Child == null || _vista.Child.Visible != true) && (_login.Cargo == "SUP_CALIDAD"))
            {
                _vista.Child = new VistaListaOPSupCalidad(_login);
                _vista.Child.MdiParent = this._vista;
                _vista.Child.Show();
            }
        }

        public void IniciarVistaListaOP()
        {
            if ((_vista.Child == null || _vista.Child.Visible != true) && (_login.Cargo == "SUP_LINEA"))
            {
                _vista.Child = new VistaListaOP(_login);
                _vista.Child.MdiParent = this._vista;
                _vista.Child.Show();
            }
        }

        public void IniciarVistaListaModelos()
        {
            if ((_vista.Child == null || _vista.Child.Visible != true) && (_login.Cargo == "ADMIN"))
            {
                //_vista.Child = new VistaListaModelos(_login);
                _vista.Child.MdiParent = this._vista;
                _vista.Child.Show();
            }
        }

        public void IniciarVistaListaColores()
        {
            if ((_vista.Child == null || _vista.Child.Visible != true) && (_login.Cargo == "ADMIN"))
            {
                //_vista.Child = new VistaListaColores(_login);
                _vista.Child.MdiParent = this._vista;
                _vista.Child.Show();
            }
        }
    }
}
