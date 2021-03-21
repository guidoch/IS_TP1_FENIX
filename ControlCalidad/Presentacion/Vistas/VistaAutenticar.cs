using Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas
{
    public partial class VistaAutenticar : Form
    {
        private PresentadorAutenticar _presentador;
        public VistaAutenticar()
        {
            this._presentador = new PresentadorAutenticar(this);
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _presentador.Login(tBoxUser.Text, tBoxPass.Text);
        }

        private void VistaAutenticar_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        public void Actualizar()
        {
            tBoxUser.Text = "";
            tBoxPass.Text = "";
        }
    }
}
