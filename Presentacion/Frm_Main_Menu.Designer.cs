
namespace Presentacion
{
    partial class Frm_Main_Menu
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
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.pnl_hijo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Lateral = new System.Windows.Forms.Panel();
            this.Frm_Usuarios_Main = new System.Windows.Forms.Button();
            this.Frm_Bitacora = new System.Windows.Forms.Button();
            this.Frm_Medico = new System.Windows.Forms.Button();
            this.Link_Perfil = new System.Windows.Forms.LinkLabel();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.Frm_Catalogo = new System.Windows.Forms.Button();
            this.Frm_Reportes = new System.Windows.Forms.Button();
            this.Frm_Facturacion = new System.Windows.Forms.Button();
            this.Frm_Examenes_Med = new System.Windows.Forms.Button();
            this.Frm_Empleados = new System.Windows.Forms.Button();
            this.Frm_Calendario = new System.Windows.Forms.Button();
            this.Frm_Pacientes = new System.Windows.Forms.Button();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.btn_nornal = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.PictureBox();
            this.btn_max = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.pnl_contenedor.SuspendLayout();
            this.pnl_hijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_nornal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_contenedor.Controls.Add(this.pnl_hijo);
            this.pnl_contenedor.Controls.Add(this.pnl_Lateral);
            this.pnl_contenedor.Controls.Add(this.pnl_titulo);
            this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenedor.Location = new System.Drawing.Point(0, 0);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(1100, 650);
            this.pnl_contenedor.TabIndex = 0;
            // 
            // pnl_hijo
            // 
            this.pnl_hijo.BackColor = System.Drawing.Color.White;
            this.pnl_hijo.Controls.Add(this.pictureBox1);
            this.pnl_hijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_hijo.Location = new System.Drawing.Point(250, 40);
            this.pnl_hijo.Name = "pnl_hijo";
            this.pnl_hijo.Size = new System.Drawing.Size(850, 610);
            this.pnl_hijo.TabIndex = 2;
            this.pnl_hijo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_hijo_Paint);
            this.pnl_hijo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_hijo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Imagen_de_WhatsApp_2023_02_24_a_las_19_44_29;
            this.pictureBox1.Location = new System.Drawing.Point(219, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_Lateral
            // 
            this.pnl_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.pnl_Lateral.Controls.Add(this.Frm_Usuarios_Main);
            this.pnl_Lateral.Controls.Add(this.Frm_Bitacora);
            this.pnl_Lateral.Controls.Add(this.Frm_Medico);
            this.pnl_Lateral.Controls.Add(this.Link_Perfil);
            this.pnl_Lateral.Controls.Add(this.lbl_email);
            this.pnl_Lateral.Controls.Add(this.lbl_cargo);
            this.pnl_Lateral.Controls.Add(this.lbl_nombre);
            this.pnl_Lateral.Controls.Add(this.pictureBox2);
            this.pnl_Lateral.Controls.Add(this.btn_Cerrar);
            this.pnl_Lateral.Controls.Add(this.Frm_Catalogo);
            this.pnl_Lateral.Controls.Add(this.Frm_Reportes);
            this.pnl_Lateral.Controls.Add(this.Frm_Facturacion);
            this.pnl_Lateral.Controls.Add(this.Frm_Examenes_Med);
            this.pnl_Lateral.Controls.Add(this.Frm_Empleados);
            this.pnl_Lateral.Controls.Add(this.Frm_Calendario);
            this.pnl_Lateral.Controls.Add(this.Frm_Pacientes);
            this.pnl_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Lateral.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Lateral.Location = new System.Drawing.Point(0, 40);
            this.pnl_Lateral.Name = "pnl_Lateral";
            this.pnl_Lateral.Size = new System.Drawing.Size(250, 610);
            this.pnl_Lateral.TabIndex = 1;
            this.pnl_Lateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Lateral_MouseDown);
            // 
            // Frm_Usuarios_Main
            // 
            this.Frm_Usuarios_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Usuarios_Main.FlatAppearance.BorderSize = 0;
            this.Frm_Usuarios_Main.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Usuarios_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Usuarios_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Usuarios_Main.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Usuarios_Main.ForeColor = System.Drawing.Color.White;
            this.Frm_Usuarios_Main.Image = global::Presentacion.Properties.Resources.user_25px;
            this.Frm_Usuarios_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Usuarios_Main.Location = new System.Drawing.Point(0, 525);
            this.Frm_Usuarios_Main.Name = "Frm_Usuarios_Main";
            this.Frm_Usuarios_Main.Size = new System.Drawing.Size(250, 45);
            this.Frm_Usuarios_Main.TabIndex = 13;
            this.Frm_Usuarios_Main.Text = "Usuarios";
            this.Frm_Usuarios_Main.UseVisualStyleBackColor = false;
            this.Frm_Usuarios_Main.Click += new System.EventHandler(this.button11_Click);
            // 
            // Frm_Bitacora
            // 
            this.Frm_Bitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Bitacora.FlatAppearance.BorderSize = 0;
            this.Frm_Bitacora.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Bitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Bitacora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Bitacora.ForeColor = System.Drawing.Color.White;
            this.Frm_Bitacora.Image = global::Presentacion.Properties.Resources.saddle_stitched_booklet_25px;
            this.Frm_Bitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Bitacora.Location = new System.Drawing.Point(0, 477);
            this.Frm_Bitacora.Name = "Frm_Bitacora";
            this.Frm_Bitacora.Size = new System.Drawing.Size(250, 45);
            this.Frm_Bitacora.TabIndex = 12;
            this.Frm_Bitacora.Text = "Bitacora e Inventario";
            this.Frm_Bitacora.UseVisualStyleBackColor = false;
            this.Frm_Bitacora.Click += new System.EventHandler(this.button10_Click);
            // 
            // Frm_Medico
            // 
            this.Frm_Medico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Medico.FlatAppearance.BorderSize = 0;
            this.Frm_Medico.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Medico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Medico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Medico.ForeColor = System.Drawing.Color.White;
            this.Frm_Medico.Image = global::Presentacion.Properties.Resources.user_25px;
            this.Frm_Medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Medico.Location = new System.Drawing.Point(0, 383);
            this.Frm_Medico.Name = "Frm_Medico";
            this.Frm_Medico.Size = new System.Drawing.Size(250, 45);
            this.Frm_Medico.TabIndex = 11;
            this.Frm_Medico.Text = "Medicos";
            this.Frm_Medico.UseVisualStyleBackColor = false;
            this.Frm_Medico.Click += new System.EventHandler(this.button9_Click);
            // 
            // Link_Perfil
            // 
            this.Link_Perfil.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(64)))));
            this.Link_Perfil.AutoSize = true;
            this.Link_Perfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Perfil.LinkColor = System.Drawing.Color.White;
            this.Link_Perfil.Location = new System.Drawing.Point(58, 70);
            this.Link_Perfil.Name = "Link_Perfil";
            this.Link_Perfil.Size = new System.Drawing.Size(67, 21);
            this.Link_Perfil.TabIndex = 1;
            this.Link_Perfil.TabStop = true;
            this.Link_Perfil.Text = "Mi Perfil";
            this.Link_Perfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Perfil_LinkClicked);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(57, 50);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(154, 21);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Correo Electronico";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.ForeColor = System.Drawing.Color.White;
            this.lbl_cargo.Location = new System.Drawing.Point(57, 29);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(148, 21);
            this.lbl_cargo.TabIndex = 9;
            this.lbl_cargo.Text = "Cargo del Usuario";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(57, 6);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(161, 21);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre del Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.test_account_100px;
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_Cerrar.Image = global::Presentacion.Properties.Resources.logout_25px;
            this.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cerrar.Location = new System.Drawing.Point(-3, 563);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(250, 45);
            this.btn_Cerrar.TabIndex = 14;
            this.btn_Cerrar.Text = "Cerrar Sesión";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_Catalogo
            // 
            this.Frm_Catalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Catalogo.FlatAppearance.BorderSize = 0;
            this.Frm_Catalogo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Catalogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Catalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Catalogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Catalogo.ForeColor = System.Drawing.Color.White;
            this.Frm_Catalogo.Image = global::Presentacion.Properties.Resources.saddle_stitched_booklet_25px;
            this.Frm_Catalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Catalogo.Location = new System.Drawing.Point(0, 287);
            this.Frm_Catalogo.Name = "Frm_Catalogo";
            this.Frm_Catalogo.Size = new System.Drawing.Size(250, 45);
            this.Frm_Catalogo.TabIndex = 7;
            this.Frm_Catalogo.Text = "Catalogo de Examenes";
            this.Frm_Catalogo.UseVisualStyleBackColor = false;
            this.Frm_Catalogo.Click += new System.EventHandler(this.button8_Click);
            // 
            // Frm_Reportes
            // 
            this.Frm_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Reportes.FlatAppearance.BorderSize = 0;
            this.Frm_Reportes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Reportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Reportes.ForeColor = System.Drawing.Color.White;
            this.Frm_Reportes.Image = global::Presentacion.Properties.Resources.report_file_25px;
            this.Frm_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Reportes.Location = new System.Drawing.Point(0, 430);
            this.Frm_Reportes.Name = "Frm_Reportes";
            this.Frm_Reportes.Size = new System.Drawing.Size(250, 45);
            this.Frm_Reportes.TabIndex = 6;
            this.Frm_Reportes.Text = "Reportes";
            this.Frm_Reportes.UseVisualStyleBackColor = false;
            this.Frm_Reportes.Click += new System.EventHandler(this.button7_Click);
            // 
            // Frm_Facturacion
            // 
            this.Frm_Facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Facturacion.FlatAppearance.BorderSize = 0;
            this.Frm_Facturacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Facturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Facturacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Facturacion.ForeColor = System.Drawing.Color.White;
            this.Frm_Facturacion.Image = global::Presentacion.Properties.Resources.project_25px;
            this.Frm_Facturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Facturacion.Location = new System.Drawing.Point(0, 335);
            this.Frm_Facturacion.Name = "Frm_Facturacion";
            this.Frm_Facturacion.Size = new System.Drawing.Size(250, 45);
            this.Frm_Facturacion.TabIndex = 5;
            this.Frm_Facturacion.Text = "Facturación";
            this.Frm_Facturacion.UseVisualStyleBackColor = false;
            this.Frm_Facturacion.Click += new System.EventHandler(this.button6_Click);
            // 
            // Frm_Examenes_Med
            // 
            this.Frm_Examenes_Med.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Examenes_Med.FlatAppearance.BorderSize = 0;
            this.Frm_Examenes_Med.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Examenes_Med.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Examenes_Med.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Examenes_Med.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Examenes_Med.ForeColor = System.Drawing.Color.White;
            this.Frm_Examenes_Med.Image = global::Presentacion.Properties.Resources.scorecard_25px;
            this.Frm_Examenes_Med.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Examenes_Med.Location = new System.Drawing.Point(0, 240);
            this.Frm_Examenes_Med.Name = "Frm_Examenes_Med";
            this.Frm_Examenes_Med.Size = new System.Drawing.Size(250, 45);
            this.Frm_Examenes_Med.TabIndex = 3;
            this.Frm_Examenes_Med.Text = "Examenes Medicos";
            this.Frm_Examenes_Med.UseVisualStyleBackColor = false;
            this.Frm_Examenes_Med.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_Empleados
            // 
            this.Frm_Empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Empleados.FlatAppearance.BorderSize = 0;
            this.Frm_Empleados.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Empleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Empleados.ForeColor = System.Drawing.Color.White;
            this.Frm_Empleados.Image = global::Presentacion.Properties.Resources.user_25px;
            this.Frm_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Empleados.Location = new System.Drawing.Point(0, 193);
            this.Frm_Empleados.Name = "Frm_Empleados";
            this.Frm_Empleados.Size = new System.Drawing.Size(250, 45);
            this.Frm_Empleados.TabIndex = 2;
            this.Frm_Empleados.Text = "Empleados";
            this.Frm_Empleados.UseVisualStyleBackColor = false;
            this.Frm_Empleados.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Calendario
            // 
            this.Frm_Calendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Calendario.FlatAppearance.BorderSize = 0;
            this.Frm_Calendario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Calendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Calendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Calendario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Calendario.ForeColor = System.Drawing.Color.White;
            this.Frm_Calendario.Image = global::Presentacion.Properties.Resources.Calendar_7_25px;
            this.Frm_Calendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Calendario.Location = new System.Drawing.Point(0, 146);
            this.Frm_Calendario.Name = "Frm_Calendario";
            this.Frm_Calendario.Size = new System.Drawing.Size(250, 45);
            this.Frm_Calendario.TabIndex = 1;
            this.Frm_Calendario.Text = "Calendario";
            this.Frm_Calendario.UseVisualStyleBackColor = false;
            this.Frm_Calendario.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Pacientes
            // 
            this.Frm_Pacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Frm_Pacientes.FlatAppearance.BorderSize = 0;
            this.Frm_Pacientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.Frm_Pacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.Frm_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frm_Pacientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_Pacientes.ForeColor = System.Drawing.Color.White;
            this.Frm_Pacientes.Image = global::Presentacion.Properties.Resources.person_24px;
            this.Frm_Pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Frm_Pacientes.Location = new System.Drawing.Point(0, 99);
            this.Frm_Pacientes.Name = "Frm_Pacientes";
            this.Frm_Pacientes.Size = new System.Drawing.Size(250, 45);
            this.Frm_Pacientes.TabIndex = 0;
            this.Frm_Pacientes.Text = "Pacientes";
            this.Frm_Pacientes.UseVisualStyleBackColor = false;
            this.Frm_Pacientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.pnl_titulo.Controls.Add(this.btn_nornal);
            this.pnl_titulo.Controls.Add(this.btn_min);
            this.pnl_titulo.Controls.Add(this.btn_max);
            this.pnl_titulo.Controls.Add(this.btn_close);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1100, 40);
            this.pnl_titulo.TabIndex = 0;
            this.pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_titulo_Paint);
            this.pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseDown);
            // 
            // btn_nornal
            // 
            this.btn_nornal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nornal.BackColor = System.Drawing.Color.White;
            this.btn_nornal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nornal.Image = global::Presentacion.Properties.Resources.normal_screen_32px;
            this.btn_nornal.Location = new System.Drawing.Point(1050, 0);
            this.btn_nornal.Name = "btn_nornal";
            this.btn_nornal.Size = new System.Drawing.Size(25, 25);
            this.btn_nornal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_nornal.TabIndex = 3;
            this.btn_nornal.TabStop = false;
            this.btn_nornal.Click += new System.EventHandler(this.btn_nornal_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.White;
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Image = global::Presentacion.Properties.Resources.minimize_window_25px;
            this.btn_min.Location = new System.Drawing.Point(1026, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(25, 25);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_min.TabIndex = 2;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.White;
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.Image = global::Presentacion.Properties.Resources.icons8_maximize_window_252;
            this.btn_max.Location = new System.Drawing.Point(1050, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(25, 25);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_max.TabIndex = 1;
            this.btn_max.TabStop = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::Presentacion.Properties.Resources.delete_25px;
            this.btn_close.Location = new System.Drawing.Point(1075, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Frm_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnl_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "Frm_Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.Frm_Main_Menu_Load);
            this.pnl_contenedor.ResumeLayout(false);
            this.pnl_hijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Lateral.ResumeLayout(false);
            this.pnl_Lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_nornal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.Panel pnl_Lateral;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_hijo;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox btn_min;
        private System.Windows.Forms.PictureBox btn_max;
        private System.Windows.Forms.PictureBox btn_nornal;
        private System.Windows.Forms.Button Frm_Pacientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Frm_Calendario;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button Frm_Catalogo;
        private System.Windows.Forms.Button Frm_Reportes;
        private System.Windows.Forms.Button Frm_Facturacion;
        private System.Windows.Forms.Button Frm_Examenes_Med;
        private System.Windows.Forms.Button Frm_Empleados;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.LinkLabel Link_Perfil;
        private System.Windows.Forms.Button Frm_Medico;
        private System.Windows.Forms.Button Frm_Bitacora;
        private System.Windows.Forms.Button Frm_Usuarios_Main;
    }
}