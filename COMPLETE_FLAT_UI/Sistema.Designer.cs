namespace ConsultaDistribuida
{
    partial class Sistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.panelContenedorForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnIzcalli = new System.Windows.Forms.Button();
            this.btnSatellite = new System.Windows.Forms.Button();
            this.btnPolanco = new System.Windows.Forms.Button();
            this.btn_Veracruz = new System.Windows.Forms.Button();
            this.btn_Alumnos = new System.Windows.Forms.Button();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.panelContenedorPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorPrincipal
            // 
            this.panelContenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelContenedorPrincipal.Controls.Add(this.panelContenedorForm);
            this.panelContenedorPrincipal.Controls.Add(this.panel1);
            this.panelContenedorPrincipal.Controls.Add(this.panelMenu);
            this.panelContenedorPrincipal.Controls.Add(this.PanelBarraTitulo);
            this.panelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            this.panelContenedorPrincipal.Size = new System.Drawing.Size(1100, 600);
            this.panelContenedorPrincipal.TabIndex = 0;
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.BackColor = System.Drawing.Color.White;
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(0, 116);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(1100, 384);
            this.panelContenedorForm.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 100);
            this.panel1.TabIndex = 5;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.Black;
            this.lbFecha.Location = new System.Drawing.Point(838, 71);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(222, 22);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Trebuchet MS", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(842, 11);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(209, 59);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(147)))));
            this.panelMenu.Controls.Add(this.btnIzcalli);
            this.panelMenu.Controls.Add(this.btnSatellite);
            this.panelMenu.Controls.Add(this.btnPolanco);
            this.panelMenu.Controls.Add(this.btn_Veracruz);
            this.panelMenu.Controls.Add(this.btn_Alumnos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 43);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1100, 73);
            this.panelMenu.TabIndex = 2;
            // 
            // btnIzcalli
            // 
            this.btnIzcalli.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIzcalli.FlatAppearance.BorderSize = 0;
            this.btnIzcalli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnIzcalli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnIzcalli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzcalli.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzcalli.ForeColor = System.Drawing.Color.Silver;
            this.btnIzcalli.Image = ((System.Drawing.Image)(resources.GetObject("btnIzcalli.Image")));
            this.btnIzcalli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzcalli.Location = new System.Drawing.Point(441, 16);
            this.btnIzcalli.Name = "btnIzcalli";
            this.btnIzcalli.Size = new System.Drawing.Size(131, 40);
            this.btnIzcalli.TabIndex = 0;
            this.btnIzcalli.Text = "Izcalli";
            this.btnIzcalli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzcalli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzcalli.UseVisualStyleBackColor = true;
            this.btnIzcalli.Click += new System.EventHandler(this.btnIzcalli_Click);
            // 
            // btnSatellite
            // 
            this.btnSatellite.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSatellite.FlatAppearance.BorderSize = 0;
            this.btnSatellite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnSatellite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnSatellite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatellite.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatellite.ForeColor = System.Drawing.Color.Silver;
            this.btnSatellite.Image = ((System.Drawing.Image)(resources.GetObject("btnSatellite.Image")));
            this.btnSatellite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatellite.Location = new System.Drawing.Point(304, 16);
            this.btnSatellite.Name = "btnSatellite";
            this.btnSatellite.Size = new System.Drawing.Size(131, 40);
            this.btnSatellite.TabIndex = 0;
            this.btnSatellite.Text = "Satellite";
            this.btnSatellite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatellite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSatellite.UseVisualStyleBackColor = true;
            this.btnSatellite.Click += new System.EventHandler(this.btnSatellite_Click);
            // 
            // btnPolanco
            // 
            this.btnPolanco.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPolanco.FlatAppearance.BorderSize = 0;
            this.btnPolanco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnPolanco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnPolanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolanco.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolanco.ForeColor = System.Drawing.Color.Silver;
            this.btnPolanco.Image = ((System.Drawing.Image)(resources.GetObject("btnPolanco.Image")));
            this.btnPolanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolanco.Location = new System.Drawing.Point(167, 16);
            this.btnPolanco.Name = "btnPolanco";
            this.btnPolanco.Size = new System.Drawing.Size(131, 40);
            this.btnPolanco.TabIndex = 0;
            this.btnPolanco.Text = "Polanco";
            this.btnPolanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPolanco.UseVisualStyleBackColor = true;
            this.btnPolanco.Click += new System.EventHandler(this.btnPolanco_Click);
            // 
            // btn_Veracruz
            // 
            this.btn_Veracruz.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Veracruz.FlatAppearance.BorderSize = 0;
            this.btn_Veracruz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btn_Veracruz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btn_Veracruz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Veracruz.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Veracruz.ForeColor = System.Drawing.Color.Silver;
            this.btn_Veracruz.Image = ((System.Drawing.Image)(resources.GetObject("btn_Veracruz.Image")));
            this.btn_Veracruz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Veracruz.Location = new System.Drawing.Point(18, 16);
            this.btn_Veracruz.Name = "btn_Veracruz";
            this.btn_Veracruz.Size = new System.Drawing.Size(131, 40);
            this.btn_Veracruz.TabIndex = 0;
            this.btn_Veracruz.Text = "Veracruz";
            this.btn_Veracruz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Veracruz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Veracruz.UseVisualStyleBackColor = true;
            this.btn_Veracruz.Click += new System.EventHandler(this.btn_Veracruz_Click);
            // 
            // btn_Alumnos
            // 
            this.btn_Alumnos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Alumnos.FlatAppearance.BorderSize = 0;
            this.btn_Alumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btn_Alumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btn_Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alumnos.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alumnos.ForeColor = System.Drawing.Color.Silver;
            this.btn_Alumnos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alumnos.Image")));
            this.btn_Alumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alumnos.Location = new System.Drawing.Point(928, 16);
            this.btn_Alumnos.Name = "btn_Alumnos";
            this.btn_Alumnos.Size = new System.Drawing.Size(154, 40);
            this.btn_Alumnos.TabIndex = 2;
            this.btn_Alumnos.Text = "Alumnos";
            this.btn_Alumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Alumnos.UseVisualStyleBackColor = true;
            this.btn_Alumnos.Click += new System.EventHandler(this.btn_Alumnos_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.PanelBarraTitulo.Controls.Add(this.pictureBox8);
            this.PanelBarraTitulo.Controls.Add(this.label1);
            this.PanelBarraTitulo.Controls.Add(this.btnNormal);
            this.PanelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBarraTitulo.ForeColor = System.Drawing.Color.White;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1100, 43);
            this.PanelBarraTitulo.TabIndex = 1;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(9, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ACTIVIDAD 3 - BASE DE DATOS DISTRIBUIDAS";
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(994, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(43, 43);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(950, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 43);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(996, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(43, 43);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1043, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 39);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContenedorPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "Sistema";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.panelContenedorPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.PanelBarraTitulo.ResumeLayout(false);
            this.PanelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorPrincipal;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelContenedorForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_Alumnos;
        private System.Windows.Forms.Button btn_Veracruz;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Button btnIzcalli;
        private System.Windows.Forms.Button btnSatellite;
        private System.Windows.Forms.Button btnPolanco;
    }
}

