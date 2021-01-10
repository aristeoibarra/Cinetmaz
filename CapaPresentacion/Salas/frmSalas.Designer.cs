
namespace CapaPresentacion.Salas
{
    partial class frmSalas
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
            this.BtnReservas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).BeginInit();
            this.spContenedor.Panel1.SuspendLayout();
            this.spContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(266, 6);
            // 
            // spContenedor
            // 
            this.spContenedor.Size = new System.Drawing.Size(800, 561);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.BtnReservas);
            this.panelBotones.Controls.SetChildIndex(this.cmdNuevo, 0);
            this.panelBotones.Controls.SetChildIndex(this.cmdModificar, 0);
            this.panelBotones.Controls.SetChildIndex(this.cmdEliminar, 0);
            this.panelBotones.Controls.SetChildIndex(this.BtnReservas, 0);
            // 
            // BtnReservas
            // 
            this.BtnReservas.Location = new System.Drawing.Point(396, 6);
            this.BtnReservas.Name = "BtnReservas";
            this.BtnReservas.Size = new System.Drawing.Size(129, 38);
            this.BtnReservas.TabIndex = 13;
            this.BtnReservas.Text = "Ver Reservas";
            this.BtnReservas.UseVisualStyleBackColor = true;
            this.BtnReservas.Click += new System.EventHandler(this.BtnReservas_Click);
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Name = "frmSalas";
            this.Text = "Salas";
            this.Load += new System.EventHandler(this.frmSalas_Load);
            this.spContenedor.Panel1.ResumeLayout(false);
            this.spContenedor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).EndInit();
            this.spContenedor.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReservas;
    }
}