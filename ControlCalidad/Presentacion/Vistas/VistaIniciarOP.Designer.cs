using AccesoExterno.ReferenciaServicio;

namespace Presentacion.Vistas
{
    partial class VistaIniciarOP
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
            this.cBoxModelo = new System.Windows.Forms.ComboBox();
            this.textNumeroOP = new System.Windows.Forms.TextBox();
            this.cBoxColor = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.labelSupLinea = new System.Windows.Forms.Label();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBoxLinea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lineaTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxModelo
            // 
            this.cBoxModelo.FormattingEnabled = true;
            this.cBoxModelo.Location = new System.Drawing.Point(466, 215);
            this.cBoxModelo.Name = "cBoxModelo";
            this.cBoxModelo.Size = new System.Drawing.Size(166, 21);
            this.cBoxModelo.TabIndex = 0;
            // 
            // textNumeroOP
            // 
            this.textNumeroOP.Location = new System.Drawing.Point(466, 189);
            this.textNumeroOP.Name = "textNumeroOP";
            this.textNumeroOP.Size = new System.Drawing.Size(166, 20);
            this.textNumeroOP.TabIndex = 1;
            // 
            // cBoxColor
            // 
            this.cBoxColor.FormattingEnabled = true;
            this.cBoxColor.Location = new System.Drawing.Point(466, 242);
            this.cBoxColor.Name = "cBoxColor";
            this.cBoxColor.Size = new System.Drawing.Size(166, 21);
            this.cBoxColor.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(415, 311);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(217, 50);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // labelSupLinea
            // 
            this.labelSupLinea.AutoSize = true;
            this.labelSupLinea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Nombre", true));
            this.labelSupLinea.Location = new System.Drawing.Point(12, 9);
            this.labelSupLinea.Name = "labelSupLinea";
            this.labelSupLinea.Size = new System.Drawing.Size(26, 13);
            this.labelSupLinea.TabIndex = 4;
            this.labelSupLinea.Text = "Sup";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.AutenticarDTO);
            // 
            // cBoxLinea
            // 
            this.cBoxLinea.FormattingEnabled = true;
            this.cBoxLinea.Location = new System.Drawing.Point(466, 269);
            this.cBoxLinea.Name = "cBoxLinea";
            this.cBoxLinea.Size = new System.Drawing.Size(166, 21);
            this.cBoxLinea.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Linea";
            // 
            // lineaTrabajoBindingSource
            // 
            this.lineaTrabajoBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.LineaTrabajoDTO);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.ColorDTO);
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(AccesoExterno.ReferenciaServicio.ModeloDTO);
            // 
            // VistaIniciarOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxLinea);
            this.Controls.Add(this.labelSupLinea);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cBoxColor);
            this.Controls.Add(this.textNumeroOP);
            this.Controls.Add(this.cBoxModelo);
            this.Name = "VistaIniciarOP";
            this.Text = "Iniciar OP";
            this.Load += new System.EventHandler(this.VistaIniciarOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxModelo;
        private System.Windows.Forms.TextBox textNumeroOP;
        private System.Windows.Forms.ComboBox cBoxColor;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label labelSupLinea;
        private System.Windows.Forms.ComboBox cBoxLinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private System.Windows.Forms.BindingSource lineaTrabajoBindingSource;
    }
}