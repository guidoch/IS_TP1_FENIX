using AccesoExterno.ReferenciaServicio;

namespace Presentacion.Vistas
{
    partial class VistaListaOPSupCalidad
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
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hermanadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnHermanar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 653);
            this.dataGridView1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Nombre", true));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.AutenticarDTO);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Asociar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHermanar
            // 
            this.btnHermanar.Location = new System.Drawing.Point(777, 92);
            this.btnHermanar.Name = "btnHermanar";
            this.btnHermanar.Size = new System.Drawing.Size(208, 48);
            this.btnHermanar.TabIndex = 5;
            this.btnHermanar.Text = "Cargar Hermanado";
            this.btnHermanar.UseVisualStyleBackColor = true;
            this.btnHermanar.Click += new System.EventHandler(this.btnHermanar_Click);
            // 
            // VistaListaOPSupCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnHermanar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VistaListaOPSupCalidad";
            this.Text = "Lista OP";
            this.Load += new System.EventHandler(this.VistaListaOPSupCalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hermanadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oPBindingSource;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.Button btnHermanar;
    }
}