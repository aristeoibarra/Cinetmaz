
namespace CapaPresentacion.Clientes
{
    partial class frmClientes
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
            this.cmbActivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).BeginInit();
            this.spContenedor.Panel1.SuspendLayout();
            this.spContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(575, 6);
            // 
            // cmdHabilitar
            // 
            this.cmdHabilitar.Location = new System.Drawing.Point(439, 6);
            // 
            // cmdDeshabilitar
            // 
            this.cmdDeshabilitar.Location = new System.Drawing.Point(275, 6);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(136, 6);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(23, 6);
            // 
            // spContenedor
            // 
            // 
            // spContenedor.Panel1
            // 
            this.spContenedor.Panel1.Controls.Add(this.cmbActivo);
            this.spContenedor.Size = new System.Drawing.Size(969, 560);
            // 
            // cmbActivo
            // 
            this.cmbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbActivo.FormattingEnabled = true;
            this.cmbActivo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbActivo.Location = new System.Drawing.Point(748, 44);
            this.cmbActivo.Name = "cmbActivo";
            this.cmbActivo.Size = new System.Drawing.Size(193, 28);
            this.cmbActivo.TabIndex = 9;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 560);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.spContenedor.Panel1.ResumeLayout(false);
            this.spContenedor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).EndInit();
            this.spContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbActivo;
    }
}