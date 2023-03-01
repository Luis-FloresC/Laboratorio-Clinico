
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
            this.pnl_Lateral = new System.Windows.Forms.Panel();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nornal = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.PictureBox();
            this.btn_max = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.pnl_contenedor.SuspendLayout();
            this.pnl_hijo.SuspendLayout();
            this.pnl_Lateral.SuspendLayout();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnl_contenedor.Size = new System.Drawing.Size(1100, 600);
            this.pnl_contenedor.TabIndex = 0;
            // 
            // pnl_hijo
            // 
            this.pnl_hijo.BackColor = System.Drawing.Color.White;
            this.pnl_hijo.Controls.Add(this.pictureBox1);
            this.pnl_hijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_hijo.Location = new System.Drawing.Point(250, 40);
            this.pnl_hijo.Name = "pnl_hijo";
            this.pnl_hijo.Size = new System.Drawing.Size(850, 560);
            this.pnl_hijo.TabIndex = 2;
            this.pnl_hijo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_hijo_Paint);
            this.pnl_hijo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_hijo_MouseDown);
            // 
            // pnl_Lateral
            // 
            this.pnl_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.pnl_Lateral.Controls.Add(this.button5);
            this.pnl_Lateral.Controls.Add(this.button8);
            this.pnl_Lateral.Controls.Add(this.button7);
            this.pnl_Lateral.Controls.Add(this.button6);
            this.pnl_Lateral.Controls.Add(this.button4);
            this.pnl_Lateral.Controls.Add(this.button3);
            this.pnl_Lateral.Controls.Add(this.button2);
            this.pnl_Lateral.Controls.Add(this.button1);
            this.pnl_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Lateral.Location = new System.Drawing.Point(0, 40);
            this.pnl_Lateral.Name = "pnl_Lateral";
            this.pnl_Lateral.Size = new System.Drawing.Size(250, 560);
            this.pnl_Lateral.TabIndex = 1;
            this.pnl_Lateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Lateral_MouseDown);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Imagen_de_WhatsApp_2023_02_24_a_las_19_44_29;
            this.pictureBox1.Location = new System.Drawing.Point(207, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Presentacion.Properties.Resources.logout_25px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1, 431);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "Cerrar Sesión";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::Presentacion.Properties.Resources.saddle_stitched_booklet_25px;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(250, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Catalogo de Examenes";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::Presentacion.Properties.Resources.report_file_25px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1, 380);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Reportes";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Presentacion.Properties.Resources.project_25px;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-3, 329);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Proyectado";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Presentacion.Properties.Resources.scorecard_25px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Examenes";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Presentacion.Properties.Resources.user_25px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Usuarios";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Presentacion.Properties.Resources.Calendar_7_25px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calendario";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Presentacion.Properties.Resources.person_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pacientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pnl_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "Frm_Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.Frm_Main_Menu_Load);
            this.pnl_contenedor.ResumeLayout(false);
            this.pnl_hijo.ResumeLayout(false);
            this.pnl_Lateral.ResumeLayout(false);
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}