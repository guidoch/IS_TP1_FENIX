using AccesoExterno.ReferenciaServicio;

namespace Presentacion.Vistas
{
    partial class VistaCargarHermanado
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelHermanado = new System.Windows.Forms.Label();
            this.oPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBoxCargar = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hermanado actual:";
            // 
            // labelHermanado
            // 
            this.labelHermanado.AutoSize = true;
            this.labelHermanado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPBindingSource, "Hermanado", true));
            this.labelHermanado.Location = new System.Drawing.Point(561, 216);
            this.labelHermanado.Name = "labelHermanado";
            this.labelHermanado.Size = new System.Drawing.Size(35, 13);
            this.labelHermanado.TabIndex = 1;
            this.labelHermanado.Text = "label2";
            // 
            // oPBindingSource
            // 
            this.oPBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.OPDTO);
            // 
            // tBoxCargar
            // 
            this.tBoxCargar.Location = new System.Drawing.Point(460, 250);
            this.tBoxCargar.Name = "tBoxCargar";
            this.tBoxCargar.Size = new System.Drawing.Size(136, 20);
            this.tBoxCargar.TabIndex = 3;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(460, 289);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(136, 44);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Agregar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // VistaCargarHermanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.tBoxCargar);
            this.Controls.Add(this.labelHermanado);
            this.Controls.Add(this.label1);
            this.Name = "VistaCargarHermanado";
            this.Text = "Cargar Hermanado";
            this.Load += new System.EventHandler(this.VistaCargarHermanado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHermanado;
        private System.Windows.Forms.TextBox tBoxCargar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.BindingSource oPBindingSource;
    }
}