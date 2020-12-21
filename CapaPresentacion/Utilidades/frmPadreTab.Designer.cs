
namespace CapaPresentacion.Utilidades
{
    partial class frmPadreTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabDatos = new System.Windows.Forms.TabControl();
            this.tpActivos = new System.Windows.Forms.TabPage();
            this.dgvListaActivos = new System.Windows.Forms.DataGridView();
            this.tpInactivos = new System.Windows.Forms.TabPage();
            this.dgvListaInactivos = new System.Windows.Forms.DataGridView();
            this.spContenedor = new System.Windows.Forms.SplitContainer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdDeshabilitar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdEliminarInactivo = new System.Windows.Forms.Button();
            this.cmdHabilitar = new System.Windows.Forms.Button();
            this.tabDatos.SuspendLayout();
            this.tpActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaActivos)).BeginInit();
            this.tpInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).BeginInit();
            this.spContenedor.Panel1.SuspendLayout();
            this.spContenedor.Panel2.SuspendLayout();
            this.spContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.tpActivos);
            this.tabDatos.Controls.Add(this.tpInactivos);
            this.tabDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDatos.Location = new System.Drawing.Point(0, 0);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.SelectedIndex = 0;
            this.tabDatos.Size = new System.Drawing.Size(819, 368);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.SelectedIndexChanged += new System.EventHandler(this.tabDatos_SelectedIndexChanged);
            // 
            // tpActivos
            // 
            this.tpActivos.BackColor = System.Drawing.SystemColors.Control;
            this.tpActivos.Controls.Add(this.dgvListaActivos);
            this.tpActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpActivos.Location = new System.Drawing.Point(4, 29);
            this.tpActivos.Name = "tpActivos";
            this.tpActivos.Padding = new System.Windows.Forms.Padding(3);
            this.tpActivos.Size = new System.Drawing.Size(811, 335);
            this.tpActivos.TabIndex = 0;
            this.tpActivos.Text = "Activos";
            // 
            // dgvListaActivos
            // 
            this.dgvListaActivos.AllowUserToAddRows = false;
            this.dgvListaActivos.AllowUserToDeleteRows = false;
            this.dgvListaActivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListaActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dgvListaActivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaActivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaActivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaActivos.Location = new System.Drawing.Point(3, 3);
            this.dgvListaActivos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaActivos.MultiSelect = false;
            this.dgvListaActivos.Name = "dgvListaActivos";
            this.dgvListaActivos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaActivos.RowHeadersVisible = false;
            this.dgvListaActivos.RowHeadersWidth = 43;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaActivos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaActivos.Size = new System.Drawing.Size(805, 329);
            this.dgvListaActivos.TabIndex = 2;
            // 
            // tpInactivos
            // 
            this.tpInactivos.Controls.Add(this.dgvListaInactivos);
            this.tpInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpInactivos.Location = new System.Drawing.Point(4, 29);
            this.tpInactivos.Name = "tpInactivos";
            this.tpInactivos.Padding = new System.Windows.Forms.Padding(3);
            this.tpInactivos.Size = new System.Drawing.Size(811, 335);
            this.tpInactivos.TabIndex = 1;
            this.tpInactivos.Text = "Inactivos";
            this.tpInactivos.UseVisualStyleBackColor = true;
            this.tpInactivos.Click += new System.EventHandler(this.tpInactivos_Click);
            // 
            // dgvListaInactivos
            // 
            this.dgvListaInactivos.AllowUserToAddRows = false;
            this.dgvListaInactivos.AllowUserToDeleteRows = false;
            this.dgvListaInactivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaInactivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaInactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaInactivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListaInactivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dgvListaInactivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaInactivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaInactivos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaInactivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaInactivos.Location = new System.Drawing.Point(3, 3);
            this.dgvListaInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaInactivos.MultiSelect = false;
            this.dgvListaInactivos.Name = "dgvListaInactivos";
            this.dgvListaInactivos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaInactivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListaInactivos.RowHeadersVisible = false;
            this.dgvListaInactivos.RowHeadersWidth = 43;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaInactivos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListaInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaInactivos.Size = new System.Drawing.Size(805, 329);
            this.dgvListaInactivos.TabIndex = 3;
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
            this.spContenedor.Panel2.Controls.Add(this.tabDatos);
            this.spContenedor.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.spContenedor.Panel2MinSize = 0;
            this.spContenedor.Size = new System.Drawing.Size(819, 454);
            this.spContenedor.SplitterDistance = 83;
            this.spContenedor.SplitterWidth = 3;
            this.spContenedor.TabIndex = 1;
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
            this.panelBotones.Controls.Add(this.cmdDeshabilitar);
            this.panelBotones.Controls.Add(this.cmdModificar);
            this.panelBotones.Controls.Add(this.cmdNuevo);
            this.panelBotones.Controls.Add(this.cmdEliminarInactivo);
            this.panelBotones.Controls.Add(this.cmdHabilitar);
            this.panelBotones.Location = new System.Drawing.Point(21, 32);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(711, 49);
            this.panelBotones.TabIndex = 8;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Image = global::CapaPresentacion.Properties.Resources.Delete;
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminar.Location = new System.Drawing.Point(434, 6);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(113, 38);
            this.cmdEliminar.TabIndex = 11;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminar.UseVisualStyleBackColor = true;
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
            // cmdEliminarInactivo
            // 
            this.cmdEliminarInactivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdEliminarInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarInactivo.Image = global::CapaPresentacion.Properties.Resources.Delete;
            this.cmdEliminarInactivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminarInactivo.Location = new System.Drawing.Point(147, 6);
            this.cmdEliminarInactivo.Name = "cmdEliminarInactivo";
            this.cmdEliminarInactivo.Size = new System.Drawing.Size(113, 38);
            this.cmdEliminarInactivo.TabIndex = 12;
            this.cmdEliminarInactivo.Text = "Eliminar";
            this.cmdEliminarInactivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminarInactivo.UseVisualStyleBackColor = true;
            this.cmdEliminarInactivo.Visible = false;
            // 
            // cmdHabilitar
            // 
            this.cmdHabilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHabilitar.Image = global::CapaPresentacion.Properties.Resources.Habilitar;
            this.cmdHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHabilitar.Location = new System.Drawing.Point(12, 6);
            this.cmdHabilitar.Name = "cmdHabilitar";
            this.cmdHabilitar.Size = new System.Drawing.Size(116, 38);
            this.cmdHabilitar.TabIndex = 10;
            this.cmdHabilitar.Text = "Habilitar";
            this.cmdHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdHabilitar.UseVisualStyleBackColor = true;
            this.cmdHabilitar.Visible = false;
            // 
            // frmPadreTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 454);
            this.Controls.Add(this.spContenedor);
            this.Name = "frmPadreTab";
            this.Text = "frmPadreTab";
            this.Load += new System.EventHandler(this.frmPadreTab_Load);
            this.tabDatos.ResumeLayout(false);
            this.tpActivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaActivos)).EndInit();
            this.tpInactivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaInactivos)).EndInit();
            this.spContenedor.Panel1.ResumeLayout(false);
            this.spContenedor.Panel1.PerformLayout();
            this.spContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContenedor)).EndInit();
            this.spContenedor.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvListaActivos;
        public System.Windows.Forms.DataGridView dgvListaInactivos;
        public System.Windows.Forms.SplitContainer spContenedor;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Panel panelBotones;
        public System.Windows.Forms.Button cmdEliminar;
        public System.Windows.Forms.Button cmdHabilitar;
        public System.Windows.Forms.Button cmdDeshabilitar;
        public System.Windows.Forms.Button cmdModificar;
        public System.Windows.Forms.Button cmdNuevo;
        public System.Windows.Forms.Button cmdEliminarInactivo;
        public System.Windows.Forms.TabControl tabDatos;
        public System.Windows.Forms.TabPage tpActivos;
        public System.Windows.Forms.TabPage tpInactivos;
    }
}