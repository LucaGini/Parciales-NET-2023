namespace Gini.Escritorio
{
    partial class Alta
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
            lbNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtClave = new TextBox();
            txtTipoUsuario = new TextBox();
            dtpUltimaFecha = new DateTimePicker();
            SuspendLayout();
            // 
            // lbNombreUsuario
            // 
            lbNombreUsuario.AutoSize = true;
            lbNombreUsuario.Location = new Point(87, 50);
            lbNombreUsuario.Name = "lbNombreUsuario";
            lbNombreUsuario.Size = new Size(139, 20);
            lbNombreUsuario.TabIndex = 0;
            lbNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(236, 47);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(125, 27);
            txtNombreUsuario.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(251, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(466, 399);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 99);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 156);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 211);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 6;
            label4.Text = "Tipo Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 270);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 7;
            label5.Text = "Ultima Fecha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(236, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(236, 149);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 9;
            // 
            // txtTipoUsuario
            // 
            txtTipoUsuario.Location = new Point(236, 211);
            txtTipoUsuario.Name = "txtTipoUsuario";
            txtTipoUsuario.Size = new Size(125, 27);
            txtTipoUsuario.TabIndex = 10;
            // 
            // dtpUltimaFecha
            // 
            dtpUltimaFecha.Location = new Point(236, 270);
            dtpUltimaFecha.Name = "dtpUltimaFecha";
            dtpUltimaFecha.Size = new Size(250, 27);
            dtpUltimaFecha.TabIndex = 11;
            // 
            // Alta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpUltimaFecha);
            Controls.Add(txtTipoUsuario);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lbNombreUsuario);
            Name = "Alta";
            Text = "Alta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombreUsuario;
        private TextBox txtNombreUsuario;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtClave;
        private TextBox txtTipoUsuario;
        private DateTimePicker dtpUltimaFecha;
    }
}