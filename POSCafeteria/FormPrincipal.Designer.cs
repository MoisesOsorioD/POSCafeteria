namespace POSCafeteria
{
    partial class FormPrincipal
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblBienvenido = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            lblUsuario = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            lblRol = new Label();
            label6 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblFecha = new Label();
            label8 = new Label();
            btnMenuUsuarios = new Button();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(138, 12);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 3;
            label1.Text = "Cafetería \"Aromas\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Cafeteria1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBienvenido.ForeColor = Color.Black;
            lblBienvenido.Location = new Point(138, 70);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(163, 28);
            lblBienvenido.TabIndex = 4;
            lblBienvenido.Text = "¡Bienvenido(a) !";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Linen;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(648, 102);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(30, 30);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(684, 98);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(684, 118);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "User";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Linen;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ShieldBlank;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(851, 102);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(30, 30);
            iconPictureBox2.TabIndex = 8;
            iconPictureBox2.TabStop = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(887, 122);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(104, 20);
            lblRol.TabIndex = 10;
            lblRol.Text = "Administrador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(887, 102);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 9;
            label6.Text = "Rol:";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Linen;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(1043, 98);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(30, 30);
            iconPictureBox3.TabIndex = 11;
            iconPictureBox3.TabStop = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1079, 122);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(77, 20);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "29/5/2026";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(1079, 102);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 12;
            label8.Text = "Fecha:";
            // 
            // btnMenuUsuarios
            // 
            btnMenuUsuarios.BackColor = Color.Linen;
            btnMenuUsuarios.FlatStyle = FlatStyle.Flat;
            btnMenuUsuarios.Font = new Font("Segoe UI", 18F);
            btnMenuUsuarios.Image = Properties.Resources.Icono_Usuarios;
            btnMenuUsuarios.ImageAlign = ContentAlignment.TopLeft;
            btnMenuUsuarios.Location = new Point(12, 179);
            btnMenuUsuarios.Name = "btnMenuUsuarios";
            btnMenuUsuarios.Size = new Size(162, 195);
            btnMenuUsuarios.TabIndex = 14;
            btnMenuUsuarios.Text = "Usuarios";
            btnMenuUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnMenuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMenuUsuarios.UseVisualStyleBackColor = false;
            btnMenuUsuarios.Click += btnMenuUsuarios_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Brown;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(990, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(172, 48);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1174, 696);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnMenuUsuarios);
            Controls.Add(lblFecha);
            Controls.Add(label8);
            Controls.Add(iconPictureBox3);
            Controls.Add(lblRol);
            Controls.Add(label6);
            Controls.Add(iconPictureBox2);
            Controls.Add(lblUsuario);
            Controls.Add(label3);
            Controls.Add(iconPictureBox1);
            Controls.Add(lblBienvenido);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lblBienvenido;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
        private Label lblUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblRol;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label lblFecha;
        private Label label8;
        private Button btnMenuUsuarios;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}