
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
            this.btnReservar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).BeginInit();
            this.spContenedor.Panel1.SuspendLayout();
            this.spContenedor.Panel2.SuspendLayout();
            this.spContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // spContenedor
            // 
            this.spContenedor.Size = new System.Drawing.Size(800, 450);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnReservar);
            this.panelBotones.Controls.SetChildIndex(this.cmdHabilitar, 0);
            this.panelBotones.Controls.SetChildIndex(this.cmdEliminarInactivo, 0);
            this.panelBotones.Controls.SetChildIndex(this.cmdNuevo, 0);
            this.panelBotones.Controls.SetChildIndex(this.cmdModificar, 0);
            this.panelBotones.Controls.SetChildIndex(this.cmdDeshabilitar, 0);
            this.panelBotones.Controls.SetChildIndex(this.cmdEliminar, 0);
            this.panelBotones.Controls.SetChildIndex(this.btnReservar, 0);
            // 
            // tabDatos
            // 
            this.tabDatos.Size = new System.Drawing.Size(800, 364);
            // 
            // tpActivos
            // 
            this.tpActivos.Size = new System.Drawing.Size(792, 331);
            // 
            // btnReservar
            // 
            this.btnReservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.Location = new System.Drawing.Point(566, 6);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(118, 38);
            this.btnReservar.TabIndex = 13;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.spContenedor.Panel1.ResumeLayout(false);
            this.spContenedor.Panel1.PerformLayout();
            this.spContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).EndInit();
            this.spContenedor.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
    }
}