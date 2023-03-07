
namespace Presentacion
{
    partial class Frm_Editar_Perfil_Main
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
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.pnl_conetendor = new System.Windows.Forms.Panel();
            this.pnl_Titulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.pnl_Titulo.Controls.Add(this.label1);
            this.pnl_Titulo.Controls.Add(this.button2);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(524, 30);
            this.pnl_Titulo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editar Perfil";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Presentacion.Properties.Resources.delete_25px;
            this.button2.Location = new System.Drawing.Point(490, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btn_empleado);
            this.panel1.Controls.Add(this.btn_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 30);
            this.panel1.TabIndex = 5;
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_usuario.FlatAppearance.BorderSize = 0;
            this.btn_usuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.btn_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.ForeColor = System.Drawing.Color.White;
            this.btn_usuario.Image = global::Presentacion.Properties.Resources.person_24px;
            this.btn_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuario.Location = new System.Drawing.Point(3, 0);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(250, 30);
            this.btn_usuario.TabIndex = 6;
            this.btn_usuario.Text = "Editar Usuario";
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btn_empleado.FlatAppearance.BorderSize = 0;
            this.btn_empleado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.btn_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(130)))), ((int)(((byte)(235)))));
            this.btn_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleado.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleado.ForeColor = System.Drawing.Color.White;
            this.btn_empleado.Image = global::Presentacion.Properties.Resources.person_24px;
            this.btn_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleado.Location = new System.Drawing.Point(267, 0);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Size = new System.Drawing.Size(250, 30);
            this.btn_empleado.TabIndex = 7;
            this.btn_empleado.Text = "Editar Datos Personales";
            this.btn_empleado.UseVisualStyleBackColor = false;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // pnl_conetendor
            // 
            this.pnl_conetendor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_conetendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_conetendor.Location = new System.Drawing.Point(0, 60);
            this.pnl_conetendor.Name = "pnl_conetendor";
            this.pnl_conetendor.Size = new System.Drawing.Size(524, 401);
            this.pnl_conetendor.TabIndex = 6;
            // 
            // Frm_Editar_Perfil_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.pnl_conetendor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Titulo);
            this.Name = "Frm_Editar_Perfil_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Editar_Perfil_Main";
            this.Load += new System.EventHandler(this.Frm_Editar_Perfil_Main_Load);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_empleado;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Panel pnl_conetendor;
    }
}