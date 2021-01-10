
namespace CapaPresentacion
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstTipo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.tstUser = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bnGeneros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnClasificaciones = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.películasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.tstTipo,
            this.toolStripTextBox3,
            this.tstUser,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(908, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesiónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.salirToolStripMenuItem.Text = "Usuarios";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // tstTipo
            // 
            this.tstTipo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.tstTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstTipo.Name = "tstTipo";
            this.tstTipo.ReadOnly = true;
            this.tstTipo.Size = new System.Drawing.Size(100, 29);
            this.tstTipo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox3.Text = "Tipo:";
            this.toolStripTextBox3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tstUser
            // 
            this.tstUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.tstUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstUser.HideSelection = false;
            this.tstUser.Name = "tstUser";
            this.tstUser.ReadOnly = true;
            this.tstUser.Size = new System.Drawing.Size(100, 29);
            this.tstUser.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox1.Text = "Usuario:";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bnGeneros
            // 
            this.bnGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnGeneros.Location = new System.Drawing.Point(727, 16);
            this.bnGeneros.Name = "bnGeneros";
            this.bnGeneros.Size = new System.Drawing.Size(99, 60);
            this.bnGeneros.TabIndex = 4;
            this.bnGeneros.Text = "Generos";
            this.bnGeneros.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(205, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peliculas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Clasificaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(630, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(318, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Salas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(110, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(528, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Reportes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bnGeneros);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnClasificaciones);
            this.panel1.Controls.Add(this.btnPeliculas);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSalas);
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 21);
            this.panel1.TabIndex = 48;
            this.panel1.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNuevo.BackgroundImage = global::CapaPresentacion.Properties.Resources.Add;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(15, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 62);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClientes.BackgroundImage = global::CapaPresentacion.Properties.Resources.Clientes;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.Location = new System.Drawing.Point(114, 10);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(64, 62);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button6.BackgroundImage = global::CapaPresentacion.Properties.Resources.Report;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(535, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 62);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnUsuarios.BackgroundImage = global::CapaPresentacion.Properties.Resources.Admin;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.Location = new System.Drawing.Point(634, 10);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(64, 62);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnClasificaciones
            // 
            this.btnClasificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClasificaciones.BackgroundImage = global::CapaPresentacion.Properties.Resources.Clasificacion;
            this.btnClasificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClasificaciones.Location = new System.Drawing.Point(419, 10);
            this.btnClasificaciones.Name = "btnClasificaciones";
            this.btnClasificaciones.Size = new System.Drawing.Size(64, 62);
            this.btnClasificaciones.TabIndex = 3;
            this.btnClasificaciones.UseVisualStyleBackColor = false;
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPeliculas.BackgroundImage = global::CapaPresentacion.Properties.Resources.Peliculas;
            this.btnPeliculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPeliculas.Location = new System.Drawing.Point(212, 10);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(64, 62);
            this.btnPeliculas.TabIndex = 3;
            this.btnPeliculas.UseVisualStyleBackColor = false;
            // 
            // btnSalas
            // 
            this.btnSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalas.BackgroundImage = global::CapaPresentacion.Properties.Resources.Sala;
            this.btnSalas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalas.Location = new System.Drawing.Point(314, 10);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(64, 62);
            this.btnSalas.TabIndex = 3;
            this.btnSalas.UseVisualStyleBackColor = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Font = new System.Drawing.Font("Arial", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.películasToolStripMenuItem,
            this.salasToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(908, 81);
            this.menuStrip2.TabIndex = 51;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.inicioToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.House;
            this.inicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(65, 77);
            this.inicioToolStripMenuItem.Text = "Home";
            this.inicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inicioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.clientesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Clientes;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(81, 77);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // películasToolStripMenuItem
            // 
            this.películasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem,
            this.generosToolStripMenuItem1});
            this.películasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.películasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Peliculas;
            this.películasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.películasToolStripMenuItem.Name = "películasToolStripMenuItem";
            this.películasToolStripMenuItem.Size = new System.Drawing.Size(88, 77);
            this.películasToolStripMenuItem.Text = "Películas";
            this.películasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.películasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            this.peliculasToolStripMenuItem.Click += new System.EventHandler(this.peliculasToolStripMenuItem_Click);
            // 
            // generosToolStripMenuItem1
            // 
            this.generosToolStripMenuItem1.Name = "generosToolStripMenuItem1";
            this.generosToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.generosToolStripMenuItem1.Text = "Generos";
            this.generosToolStripMenuItem1.Click += new System.EventHandler(this.generosToolStripMenuItem1_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salasToolStripMenuItem1,
            this.clasificacionToolStripMenuItem});
            this.salasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.salasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Sala;
            this.salasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(62, 77);
            this.salasToolStripMenuItem.Text = "Salas";
            this.salasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // salasToolStripMenuItem1
            // 
            this.salasToolStripMenuItem1.Name = "salasToolStripMenuItem1";
            this.salasToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.salasToolStripMenuItem1.Text = "Salas";
            this.salasToolStripMenuItem1.Click += new System.EventHandler(this.salasToolStripMenuItem1_Click);
            // 
            // clasificacionToolStripMenuItem
            // 
            this.clasificacionToolStripMenuItem.Name = "clasificacionToolStripMenuItem";
            this.clasificacionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.clasificacionToolStripMenuItem.Text = "Clasificaciones";
            this.clasificacionToolStripMenuItem.Click += new System.EventHandler(this.clasificacionToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.adminToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Admin;
            this.adminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(88, 77);
            this.adminToolStripMenuItem.Text = "Usuarios";
            this.adminToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 81);
            this.panel2.TabIndex = 53;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(915, 485);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinetmaz Tello.net";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Button btnClasificaciones;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bnGeneros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripTextBox tstUser;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox tstTipo;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem películasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clasificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
    }
}

