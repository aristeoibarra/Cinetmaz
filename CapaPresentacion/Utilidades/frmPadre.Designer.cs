
namespace CapaPresentacion.Utilidades
{
    partial class frmPadre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spContenedor = new System.Windows.Forms.SplitContainer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdHabilitar = new System.Windows.Forms.Button();
            this.cmdDeshabilitar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).BeginInit();
            this.spContenedor.Panel1.SuspendLayout();
            this.spContenedor.Panel2.SuspendLayout();
            this.spContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // spContenedor
            // 
            this.spContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContenedor.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContenedor.IsSplitterFixed = true;
            this.spContenedor.Location = new System.Drawing.Point(0, 0);
            this.spContenedor.Name = "spContenedor";
            this.spContenedor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContenedor.Panel1
            // 
            this.spContenedor.Panel1.Controls.Add(this.lblTitulo);
            this.spContenedor.Panel1.Controls.Add(this.panelBotones);
            this.spContenedor.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.spContenedor.Panel1MinSize = 0;
            // 
            // spContenedor.Panel2
            // 
            this.spContenedor.Panel2.Controls.Add(this.dgvLista);
            this.spContenedor.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.spContenedor.Panel2MinSize = 0;
            this.spContenedor.Size = new System.Drawing.Size(784, 600);
            this.spContenedor.SplitterDistance = 83;
            this.spContenedor.SplitterWidth = 3;
            this.spContenedor.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 34);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Formulario";
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.cmdEliminar);
            this.panelBotones.Controls.Add(this.cmdHabilitar);
            this.panelBotones.Controls.Add(this.cmdDeshabilitar);
            this.panelBotones.Controls.Add(this.cmdModificar);
            this.panelBotones.Controls.Add(this.cmdNuevo);
            this.panelBotones.Location = new System.Drawing.Point(21, 32);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(751, 49);
            this.panelBotones.TabIndex = 8;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Image = global::CapaPresentacion.Properties.Resources.Delete;
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminar.Location = new System.Drawing.Point(563, 6);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(113, 38);
            this.cmdEliminar.TabIndex = 11;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdHabilitar
            // 
            this.cmdHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHabilitar.Image = global::CapaPresentacion.Properties.Resources.Habilitar;
            this.cmdHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHabilitar.Location = new System.Drawing.Point(430, 6);
            this.cmdHabilitar.Name = "cmdHabilitar";
            this.cmdHabilitar.Size = new System.Drawing.Size(116, 38);
            this.cmdHabilitar.TabIndex = 10;
            this.cmdHabilitar.Text = "Habilitar";
            this.cmdHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdHabilitar.UseVisualStyleBackColor = true;
            this.cmdHabilitar.Visible = false;
            // 
            // cmdDeshabilitar
            // 
            this.cmdDeshabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeshabilitar.Image = global::CapaPresentacion.Properties.Resources.Deshabilitar;
            this.cmdDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDeshabilitar.Location = new System.Drawing.Point(266, 6);
            this.cmdDeshabilitar.Name = "cmdDeshabilitar";
            this.cmdDeshabilitar.Size = new System.Drawing.Size(145, 38);
            this.cmdDeshabilitar.TabIndex = 9;
            this.cmdDeshabilitar.Text = "Deshabilitar";
            this.cmdDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDeshabilitar.UseVisualStyleBackColor = true;
            this.cmdDeshabilitar.Visible = false;
            // 
            // cmdModificar
            // 
            this.cmdModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Image = global::CapaPresentacion.Properties.Resources.Edit;
            this.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.Location = new System.Drawing.Point(127, 6);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(123, 38);
            this.cmdModificar.TabIndex = 8;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Image = global::CapaPresentacion.Properties.Resources.New1;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(12, 6);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(98, 38);
            this.cmdNuevo.TabIndex = 7;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(0, 0);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowHeadersWidth = 43;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLista.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(784, 514);
            this.dgvLista.TabIndex = 1;
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.spContenedor);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPadre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPadre";
            this.Load += new System.EventHandler(this.frmPadre_Load);
            this.spContenedor.Panel1.ResumeLayout(false);
            this.spContenedor.Panel1.PerformLayout();
            this.spContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).EndInit();
            this.spContenedor.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotones;
        public System.Windows.Forms.Button cmdEliminar;
        public System.Windows.Forms.Button cmdHabilitar;
        public System.Windows.Forms.Button cmdDeshabilitar;
        public System.Windows.Forms.Button cmdModificar;
        public System.Windows.Forms.Button cmdNuevo;
        public System.Windows.Forms.SplitContainer spContenedor;
        public System.Windows.Forms.DataGridView dgvLista;
    }
}