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
    class PresentadorListaOPSupCalidad
    {
        private VistaListaOPSupCalidad _vista;
        private AutenticarDTO _login;

        private BindingSource _bindingLogin;
        private BindingSource _bindingOP;

        public PresentadorListaOPSupCalidad(VistaListaOPSupCalidad vista, AutenticarDTO login, BindingSource bindingLogin, BindingSource bindingOP)
        {
            this._vista = vista;
            this._login = login;

            this._bindingLogin = bindingLogin;
            this._bindingOP = bindingOP;
        }

        public void Actualizar()
        {
            _bindingLogin.DataSource = _login;
            _bindingOP.DataSource = null;
            _bindingOP.DataSource = Adaptador.ListarOPs();
        }

        public void Asociar()
        {
            switch (Adaptador.AsociarOP((_bindingOP.Current as OPDTO).Numero, _login.Empleado))
            {
                case 0:
                    MessageBox.Show("Asociado a OP", "Aviso");
                    break;
                case 1:
                    MessageBox.Show("No se puede asociar a OP, supervisor ya asociado a otra op", "Aviso");
                    break;
                case 2:
                    MessageBox.Show("No se puede asociar, op ya asociada a otro supervisor de calidad.", "Aviso");
                    break;
                case 3:
                    MessageBox.Show("No se puede asociar a OP, OP no esta en proceso", "Aviso");
                    break;
                default:
                    MessageBox.Show("No se como llegue aqui xD", "ERROR");
                    break;
            }
            Actualizar();
        }

        public void CargarHermanado()
        {
            if (Adaptador.AptoCargarHermanado((_bindingOP.Current as OPDTO).Numero))
            { 
                new VistaCargarHermanado(numero).Show();
                throw new NotImplementedException();
            }
            else
            {
                MessageBox.Show("OP Finalizada, no se puede cargar hermanado.", "Aviso");
            }

        }

        public void IniciarVistaRegistrarInspeccion(int numero, int codSup)
        {
            ////new VistaRegistrarInspeccion(numero,codSup).Show();
            throw new NotImplementedException();
        }

        /*public void IniciarVistaCargarHermanado(int numero)
        {
            ////new VistaCargarHermanado(numero).Show();
            throw new NotImplementedException();
        }*/

        public void Desasociar()
        {
            ///deberiamos eliminar o cambiar por un boton de actualizacion
            Actualizar();
        }
    }
}
