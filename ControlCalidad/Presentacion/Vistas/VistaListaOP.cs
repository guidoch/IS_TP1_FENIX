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
    public partial class VistaListaOP : Form
    {
        private PresentadorListaOpSupLinea _presentador;
        public VistaListaOP(AutenticarDTO login)
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            _presentador = new PresentadorListaOpSupLinea(this, login, empleadoBindingSource, oPBindingSource);
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
        }

        private void VistaListaOP_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }

        private void btn_iniaciar_Click(object sender, EventArgs e)
        {
            _presentador.IniciarOP();
        }

        private void btn_pausar_Click(object sender, EventArgs e)
        {
            _presentador.PausarOP();
        }

        private void btn_reanudar_Click(object sender, EventArgs e)
        {
            _presentador.ReanudarOP();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            _presentador.FinalizarOP();
        }

        private void btn_vizualizar_Click(object sender, EventArgs e)
        {
            _presentador.VisualizarOP();
            //MessageBox.Show("No implementado aun :)", "Disculpas");
        }
    }
}
