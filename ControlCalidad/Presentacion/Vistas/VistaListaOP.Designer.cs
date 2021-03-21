using AccesoExterno.ReferenciaServicio;

namespace Presentacion.Vistas
{
    partial class VistaListaOP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_iniaciar = new System.Windows.Forms.Button();
            this.btn_pausar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_vizualizar = new System.Windows.Forms.Button();
            this.btn_reanudar = new System.Windows.Forms.Button();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hermanadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.hermanadoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.lineaDataGridViewTextBoxColumn,
            this.supervisorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 654);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Nombre", true));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supervisor Linea";
            // 
            // btn_iniaciar
            // 
            this.btn_iniaciar.Location = new System.Drawing.Point(778, 34);
            this.btn_iniaciar.Name = "btn_iniaciar";
            this.btn_iniaciar.Size = new System.Drawing.Size(208, 50);
            this.btn_iniaciar.TabIndex = 2;
            this.btn_iniaciar.Text = "Iniciar/Crear";
            this.btn_iniaciar.UseVisualStyleBackColor = true;
            this.btn_iniaciar.Click += new System.EventHandler(this.btn_iniaciar_Click);
            // 
            // btn_pausar
            // 
            this.btn_pausar.Location = new System.Drawing.Point(778, 106);
            this.btn_pausar.Name = "btn_pausar";
            this.btn_pausar.Size = new System.Drawing.Size(208, 50);
            this.btn_pausar.TabIndex = 3;
            this.btn_pausar.Text = "Pausar";
            this.btn_pausar.UseVisualStyleBackColor = true;
            this.btn_pausar.Click += new System.EventHandler(this.btn_pausar_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(778, 218);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(208, 50);
            this.btn_finalizar.TabIndex = 4;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_vizualizar
            // 
            this.btn_vizualizar.Location = new System.Drawing.Point(778, 274);
            this.btn_vizualizar.Name = "btn_vizualizar";
            this.btn_vizualizar.Size = new System.Drawing.Size(208, 50);
            this.btn_vizualizar.TabIndex = 5;
            this.btn_vizualizar.Text = "Visualizar";
            this.btn_vizualizar.UseVisualStyleBackColor = true;
            this.btn_vizualizar.Click += new System.EventHandler(this.btn_vizualizar_Click);
            // 
            // btn_reanudar
            // 
            this.btn_reanudar.Location = new System.Drawing.Point(778, 162);
            this.btn_reanudar.Name = "btn_reanudar";
            this.btn_reanudar.Size = new System.Drawing.Size(208, 50);
            this.btn_reanudar.TabIndex = 6;
            this.btn_reanudar.Text = "Reanudar";
            this.btn_reanudar.UseVisualStyleBackColor = true;
            this.btn_reanudar.Click += new System.EventHandler(this.btn_reanudar_Click);
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
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.AutenticarDTO);
            // 
            // VistaListaOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.btn_reanudar);
            this.Controls.Add(this.btn_vizualizar);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_pausar);
            this.Controls.Add(this.btn_iniaciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VistaListaOP";
            this.Text = "Lista OP";
            this.Load += new System.EventHandler(this.VistaListaOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oPBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_iniaciar;
        private System.Windows.Forms.Button btn_pausar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_vizualizar;
        private System.Windows.Forms.Button btn_reanudar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hermanadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
    }
}