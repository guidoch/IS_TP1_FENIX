using AccesoExterno.ReferenciaServicio;
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
    public partial class VistaPrincipal : Form
    {
        private PresentadorPrincipal _presentador;
        public Form Child { get; set; }
        public string Empleado { get; set; }

        public VistaPrincipal(AutenticarDTO login)
        {
            this._presentador = new PresentadorPrincipal(this, login);
            InitializeComponent();
            administradorToolStripMenuItem.Enabled = false;
            supervisorDeCalidadToolStripMenuItem.Enabled = false;
            sToolStripMenuItem.Enabled = false;
            datosEnLineaToolStripMenuItem.Enabled = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            switch (_presentador.Actualziar())
            {
                case "SUP_LINEA":
                    this.sToolStripMenuItem.Enabled = true;
                    break;
                case "SUP_CALIDAD":
                    this.supervisorDeCalidadToolStripMenuItem.Enabled = true;
                    break;
                case "ADMIN":
                    this.administradorToolStripMenuItem.Enabled = true;
                    break;
                default:
                    throw new NotImplementedException();
            }
            this.Text = this.Empleado;
        }

        private void autenticarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void supervisorDeCalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVistaListaOPSupCalidad();
        }


        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVistaListaOP();
        }


        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVistaListaModelos();
        }
        
        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVistaListaColores();
        }

        private void datosEnLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado aun.","Aviso");
        }

        private void VistaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.CerrarSesion();
        }

        private void CerrarSesion()
        {
            _presentador.CerrarSesion();
        }
    }
}
