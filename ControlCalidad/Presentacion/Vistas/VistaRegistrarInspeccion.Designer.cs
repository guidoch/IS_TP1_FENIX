using AccesoExterno.ReferenciaServicio;

namespace Presentacion.Vistas
{
    partial class VistaRegistrarInspeccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewOP = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hermanadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSupervidor = new System.Windows.Forms.Label();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewDefectos = new System.Windows.Forms.DataGridView();
            this.defectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBoxPie = new System.Windows.Forms.ComboBox();
            this.cBoxTipoDefecto = new System.Windows.Forms.ComboBox();
            this.tipoDefectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregarDefecto = new System.Windows.Forms.Button();
            this.btnRegistrarInsp = new System.Windows.Forms.Button();
            this.btnDesasociar = new System.Windows.Forms.Button();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDefectoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDefectoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDefectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOP
            // 
            this.dataGridViewOP.AutoGenerateColumns = false;
            this.dataGridViewOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.hermanadoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.lineaDataGridViewTextBoxColumn,
            this.supervisorDataGridViewTextBoxColumn});
            this.dataGridViewOP.DataSource = this.oPBindingSource;
            this.dataGridViewOP.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewOP.Name = "dataGridViewOP";
            this.dataGridViewOP.Size = new System.Drawing.Size(750, 51);
            this.dataGridViewOP.TabIndex = 0;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // hermanadoDataGridViewTextBoxColumn
            // 
            this.hermanadoDataGridViewTextBoxColumn.DataPropertyName = "Hermanado";
            this.hermanadoDataGridViewTextBoxColumn.HeaderText = "Hermanado";
            this.hermanadoDataGridViewTextBoxColumn.Name = "hermanadoDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // lineaDataGridViewTextBoxColumn
            // 
            this.lineaDataGridViewTextBoxColumn.DataPropertyName = "Linea";
            this.lineaDataGridViewTextBoxColumn.HeaderText = "Linea";
            this.lineaDataGridViewTextBoxColumn.Name = "lineaDataGridViewTextBoxColumn";
            // 
            // supervisorDataGridViewTextBoxColumn
            // 
            this.supervisorDataGridViewTextBoxColumn.DataPropertyName = "Supervisor";
            this.supervisorDataGridViewTextBoxColumn.HeaderText = "Supervisor";
            this.supervisorDataGridViewTextBoxColumn.Name = "supervisorDataGridViewTextBoxColumn";
            // 
            // oPBindingSource
            // 
            this.oPBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.OPDTO);
            // 
            // labelSupervidor
            // 
            this.labelSupervidor.AutoSize = true;
            this.labelSupervidor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Nombre", true));
            this.labelSupervidor.Location = new System.Drawing.Point(12, 9);
            this.labelSupervidor.Name = "labelSupervidor";
            this.labelSupervidor.Size = new System.Drawing.Size(44, 13);
            this.labelSupervidor.TabIndex = 1;
            this.labelSupervidor.Text = "Sup Cal";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.AutenticarDTO);
            // 
            // dataGridViewDefectos
            // 
            this.dataGridViewDefectos.AutoGenerateColumns = false;
            this.dataGridViewDefectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.pieDataGridViewTextBoxColumn,
            this.TipoDefectoDescripcion,
            this.TipoDefectoTipo});
            this.dataGridViewDefectos.DataSource = this.defectoBindingSource;
            this.dataGridViewDefectos.Location = new System.Drawing.Point(15, 112);
            this.dataGridViewDefectos.Name = "dataGridViewDefectos";
            this.dataGridViewDefectos.Size = new System.Drawing.Size(446, 598);
            this.dataGridViewDefectos.TabIndex = 2;
            // 
            // defectoBindingSource
            // 
            this.defectoBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.DefectoDTO);
            // 
            // cBoxPie
            // 
            this.cBoxPie.FormattingEnabled = true;
            this.cBoxPie.Location = new System.Drawing.Point(493, 112);
            this.cBoxPie.Name = "cBoxPie";
            this.cBoxPie.Size = new System.Drawing.Size(194, 21);
            this.cBoxPie.TabIndex = 3;
            // 
            // cBoxTipoDefecto
            // 
            this.cBoxTipoDefecto.DataSource = this.tipoDefectoBindingSource;
            this.cBoxTipoDefecto.FormattingEnabled = true;
            this.cBoxTipoDefecto.ItemHeight = 13;
            this.cBoxTipoDefecto.Location = new System.Drawing.Point(493, 139);
            this.cBoxTipoDefecto.Name = "cBoxTipoDefecto";
            this.cBoxTipoDefecto.Size = new System.Drawing.Size(194, 21);
            this.cBoxTipoDefecto.TabIndex = 4;
            // 
            // tipoDefectoBindingSource
            // 
            this.tipoDefectoBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.TipoDefectoDTO);
            // 
            // btnAgregarDefecto
            // 
            this.btnAgregarDefecto.Location = new System.Drawing.Point(493, 166);
            this.btnAgregarDefecto.Name = "btnAgregarDefecto";
            this.btnAgregarDefecto.Size = new System.Drawing.Size(194, 55);
            this.btnAgregarDefecto.TabIndex = 5;
            this.btnAgregarDefecto.Text = "Agregar";
            this.btnAgregarDefecto.UseVisualStyleBackColor = true;
            this.btnAgregarDefecto.Click += new System.EventHandler(this.btnAgregarDefecto_Click);
            // 
            // btnRegistrarInsp
            // 
            this.btnRegistrarInsp.Location = new System.Drawing.Point(493, 347);
            this.btnRegistrarInsp.Name = "btnRegistrarInsp";
            this.btnRegistrarInsp.Size = new System.Drawing.Size(194, 109);
            this.btnRegistrarInsp.TabIndex = 6;
            this.btnRegistrarInsp.Text = "Registrar Inspeccion";
            this.btnRegistrarInsp.UseVisualStyleBackColor = true;
            this.btnRegistrarInsp.Click += new System.EventHandler(this.btnRegistrarInsp_Click);
            // 
            // btnDesasociar
            // 
            this.btnDesasociar.Location = new System.Drawing.Point(768, 34);
            this.btnDesasociar.Name = "btnDesasociar";
            this.btnDesasociar.Size = new System.Drawing.Size(228, 51);
            this.btnDesasociar.TabIndex = 7;
            this.btnDesasociar.Text = "Desasociar";
            this.btnDesasociar.UseVisualStyleBackColor = true;
            this.btnDesasociar.Click += new System.EventHandler(this.btnDesasociar_Click);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // pieDataGridViewTextBoxColumn
            // 
            this.pieDataGridViewTextBoxColumn.DataPropertyName = "Pie";
            this.pieDataGridViewTextBoxColumn.HeaderText = "Pie";
            this.pieDataGridViewTextBoxColumn.Name = "pieDataGridViewTextBoxColumn";
            // 
            // TipoDefectoDescripcion
            // 
            this.TipoDefectoDescripcion.DataPropertyName = "TipoDefectoDescripcion";
            this.TipoDefectoDescripcion.HeaderText = "Tipo Defecto";
            this.TipoDefectoDescripcion.Name = "TipoDefectoDescripcion";
            // 
            // TipoDefectoTipo
            // 
            this.TipoDefectoTipo.DataPropertyName = "TipoDefectoTipo";
            this.TipoDefectoTipo.HeaderText = "Clase Defecto";
            this.TipoDefectoTipo.Name = "TipoDefectoTipo";
            // 
            // VistaRegistrarInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnDesasociar);
            this.Controls.Add(this.btnRegistrarInsp);
            this.Controls.Add(this.btnAgregarDefecto);
            this.Controls.Add(this.cBoxTipoDefecto);
            this.Controls.Add(this.cBoxPie);
            this.Controls.Add(this.dataGridViewDefectos);
            this.Controls.Add(this.labelSupervidor);
            this.Controls.Add(this.dataGridViewOP);
            this.Name = "VistaRegistrarInspeccion";
            this.Text = "Registrar Inspeeccion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaRegistrarInspeccion_FormClosing);
            this.Load += new System.EventHandler(this.VistaRegistrarInspeeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDefectoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOP;
        private System.Windows.Forms.Label labelSupervidor;
        private System.Windows.Forms.DataGridView dataGridViewDefectos;
        private System.Windows.Forms.ComboBox cBoxPie;
        private System.Windows.Forms.ComboBox cBoxTipoDefecto;
        private System.Windows.Forms.Button btnAgregarDefecto;
        private System.Windows.Forms.Button btnRegistrarInsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hermanadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oPBindingSource;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDefectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource defectoBindingSource;
        private System.Windows.Forms.BindingSource tipoDefectoBindingSource;
        private System.Windows.Forms.Button btnDesasociar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDefectoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDefectoTipo;
    }
}