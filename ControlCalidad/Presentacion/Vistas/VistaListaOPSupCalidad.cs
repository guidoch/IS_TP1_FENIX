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
    public partial class VistaListaOPSupCalidad : Form
    {
        private PresentadorListaOPSupCalidad _presentador;
        public VistaListaOPSupCalidad(AutenticarDTO login)
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            _presentador = new PresentadorListaOPSupCalidad(this, login, loginBindingSource, oPBindingSource);

            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
        }

        private void VistaListaOPSupCalidad_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.Asociar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presentador.Desasociar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }

        private void btnHermanar_Click(object sender, EventArgs e)
        {
            _presentador.CargarHermanado();
        }
    }
}
