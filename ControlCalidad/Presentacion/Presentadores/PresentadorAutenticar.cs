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
    class PresentadorAutenticar
    {
        private VistaAutenticar _vista;

        public PresentadorAutenticar(VistaAutenticar vista)
        {
            this._vista = vista;
        }

        public void Login(string user, string pass)
        {
            //throw new NotImplementedException();
            AutenticarDTO login = Adaptador.Autenticar(user, pass);
            switch (login.Estado)
            {
                case 0:
                    MessageBox.Show("Login exitoso.", "Aviso");
                    new VistaPrincipal(login).Show();
                    _vista.Actualizar();
                    break;
                case 2:
                    MessageBox.Show("Usuario en sesion existente.", "Aviso");
                    _vista.Actualizar();
                    break;
                case 1:
                    MessageBox.Show("Credenciales erroneas.", "Aviso");
                    _vista.Actualizar();
                    break;
                default:
                    MessageBox.Show("Como llegue aqui?", "ERROR");
                    break;
            }
        }
    }
}
