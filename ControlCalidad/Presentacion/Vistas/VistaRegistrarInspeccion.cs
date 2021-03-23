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
    public partial class VistaRegistrarInspeccion : Form
    {
        private PresentadorRegistrarInspeccion _presentador;
        public VistaRegistrarInspeccion(OPDTO op, AutenticarDTO login)
        {
            InitializeComponent();

            dataGridViewOP.AllowUserToAddRows = false;
            dataGridViewOP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOP.ReadOnly = true;
            dataGridViewDefectos.AllowUserToAddRows = false;
            dataGridViewDefectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDefectos.ReadOnly = true;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;

            //cBoxPie.DataSource = Enum.GetValues(typeof(Pie));
            cBoxPie.Items.Add("Derecho");
            cBoxPie.Items.Add("Izquierdo");
            cBoxPie.SelectedIndex = 0;

            cBoxTipoDefecto.DisplayMember = "Descripcion";
            cBoxTipoDefecto.ValueMember = "Codigo";

            _presentador = new PresentadorRegistrarInspeccion(this, op, login, loginBindingSource, oPBindingSource, defectoBindingSource, tipoDefectoBindingSource);
        }

        private void VistaRegistrarInspeeccion_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }

        private void btnAgregarDefecto_Click(object sender, EventArgs e)
        {
            /*Pie pie;
            Enum.TryParse<Pie>(cBoxPie.SelectedValue.ToString(), out pie);
            _presentador.AgregarDefecto(pie);*/
            var pie = cBoxPie.SelectedItem.ToString();
            _presentador.AgregarDefecto(pie);
        }

        private void btnRegistrarInsp_Click(object sender, EventArgs e)
        {
            _presentador.RegistrarInspeccion();
        }

        private void btnDesasociar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaRegistrarInspeccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(_presentador.Desasociar());
        }
    }
}
