﻿
namespace CapaPresentacion.Clasificaciones
{
    partial class frmClasificaciones
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
            this.spContenedor.Size = new System.Drawing.Size(790, 560);
            // 
            // frmClasificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 560);
            this.Name = "frmClasificaciones";
            this.Text = "frmClasificaciones";
            this.Load += new System.EventHandler(this.frmClasificaciones_Load);
            this.spContenedor.Panel1.ResumeLayout(false);
            this.spContenedor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).EndInit();
            this.spContenedor.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}