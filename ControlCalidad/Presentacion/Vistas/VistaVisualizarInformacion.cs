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
    public partial class VistaVisualizarInformacion : Form
    {
        private PresentadorVisualizarInformacion _presentador;
        public VistaVisualizarInformacion(OPDTO op, AutenticarDTO login)
        {
            InitializeComponent();
            _presentador = new PresentadorVisualizarInformacion(this, op, oPBindingSource);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            //this.labelTop1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingTop1, "", true));

        }

        private void VistaVizualizarInformacion_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }
        public void Actualizar(int primera, int objetivo, DataTable listaDefectos)
        {
            labelPrimera.Text = primera.ToString();
            labelObjetivo.Text = objetivo.ToString();
            dataGridView1.DataSource = listaDefectos;
            //if (this.WindowState.Equals(FormWindowState.Normal)) 
            dataGridView1.Sort(dataGridView1.Columns[2],ListSortDirection.Descending);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaVisualizarInformacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            _presentador.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }
    }
}
