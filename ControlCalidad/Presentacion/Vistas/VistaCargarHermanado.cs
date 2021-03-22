using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCalidadClientePresentacion.Presentadores;

namespace ControlCalidadClientePresentacion.Vistas
{
    public partial class VistaCargarHermanado : Form
    {
        private PresentadorCargarHermanado _presentador;
        public VistaCargarHermanado(int numero)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;

            this._presentador = new PresentadorCargarHermanado(this, numero, oPBindingSource);
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            _presentador.CargarHermanado(int.Parse(tBoxCargar.Text));
        }

        private void VistaCargarHermanado_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }
    }
}
