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
    class PresentadorRegistrarInspeccion
    {
        private VistaRegistrarInspeccion _vista;
        private BindingSource _bindingLogin;
        private BindingSource _bindingOP;
        private BindingSource _bindingDefectos;
        private BindingSource _bindingTipoDefecto;

        private OPDTO _op;
        private AutenticarDTO _login;
        private List<DefectoDTO> _defectos;

        public PresentadorRegistrarInspeccion(VistaRegistrarInspeccion vista, OPDTO op, AutenticarDTO login, BindingSource loginBindingSource, BindingSource oPBindingSource, BindingSource defectoBindingSource, BindingSource tipoDefectoBindingSource)
        {
            this._vista = vista;
            this._login = login;
            this._op = op;
            this._defectos = new List<DefectoDTO>() { };

            this._bindingLogin = loginBindingSource;
            this._bindingOP = oPBindingSource;
            this._bindingDefectos = defectoBindingSource;
            this._bindingTipoDefecto = tipoDefectoBindingSource;

        }

        internal void Actualizar()
        {
            _bindingLogin.DataSource = _login;
            _bindingOP.DataSource = _op;
            _bindingTipoDefecto.DataSource = Adaptador.ListarTipoDefectos();//RepositorioTiposDefecto.Instancia._tiposdefecto;
            _bindingDefectos.DataSource = null;
            _bindingDefectos.DataSource = _defectos;
        }

        internal void AgregarDefecto(string pie)
        {
            _defectos.Add(new DefectoDTO()
            {
                Codigo = (_defectos.Count()),
                Pie = pie,
                TipoDefectoCodigo = (_bindingTipoDefecto.Current as TipoDefectoDTO).Codigo,
                TipoDefectoDescripcion = (_bindingTipoDefecto.Current as TipoDefectoDTO).Descripcion,
                TipoDefectoTipo = (_bindingTipoDefecto.Current as TipoDefectoDTO).Tipo
            });
            Actualizar();
        }

        internal bool Desasociar()
        {
            if (Adaptador.DesasociarOP(_op.Numero))    //revisar op pausada, desasociar de periodo
            {
                MessageBox.Show("Desasociado de op", "Aviso");
                //_vista.Close();
                return true;
            }
            else
            {
                MessageBox.Show("No se puede desasociar de una op activa", "Aviso");
                return false;
            }
        }

        internal void RegistrarInspeccion()
        {
            switch (Adaptador.RegistrarInspeccion(_op.Numero, _defectos))
            {
                case 0:
                    MessageBox.Show("Inspeccion registrada.\nResultado: PRIMERA.", "Aviso");
                    break;
                case 1:
                    MessageBox.Show("Inspeccion registrada.\nResultado: OBSERVADO.", "Aviso");
                    break;
                case 2:
                    MessageBox.Show("Inspeccion registrada.\nResultado: REPROCESO.", "Aviso");
                    break;
                case 99:
                    MessageBox.Show("Inspeccion NO registrada.", "Aviso");
                    break;
                default:
                    MessageBox.Show("Como llegue aqui?", "ERROR");
                    break;
            }

            this._defectos = new List<DefectoDTO>() { };

            Actualizar();
        }
    }
}
