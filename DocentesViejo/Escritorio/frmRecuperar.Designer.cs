namespace Escritorio
{
    partial class frmRecuperar
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
            txtCuil = new TextBox();
            label1 = new Label();
            btnRecuperar = new Button();
            lblId = new Label();
            lblCuil = new Label();
            lblNombre = new Label();
            lblEmail = new Label();
            lblSalario = new Label();
            lblFechaIngreso = new Label();
            lblAntiguedad = new Label();
            SuspendLayout();
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(145, 63);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(190, 27);
            txtCuil.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 66);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese Cuil";
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(419, 62);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(94, 29);
            btnRecuperar.TabIndex = 3;
            btnRecuperar.Text = "Recuperar";
            btnRecuperar.UseVisualStyleBackColor = true;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(96, 148);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 20);
            lblId.TabIndex = 4;
            lblId.Text = "label2";
            // 
            // lblCuil
            // 
            lblCuil.AutoSize = true;
            lblCuil.Location = new Point(96, 198);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(50, 20);
            lblCuil.TabIndex = 5;
            lblCuil.Text = "label3";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(96, 251);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "label4";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(96, 303);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "label5";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(226, 148);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(50, 20);
            lblSalario.TabIndex = 8;
            lblSalario.Text = "label6";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(226, 198);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(50, 20);
            lblFechaIngreso.TabIndex = 9;
            lblFechaIngreso.Text = "label7";
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.Location = new Point(226, 251);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(50, 20);
            lblAntiguedad.TabIndex = 10;
            lblAntiguedad.Text = "label8";
            // 
            // frmRecuperar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAntiguedad);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblSalario);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblCuil);
            Controls.Add(lblId);
            Controls.Add(btnRecuperar);
            Controls.Add(label1);
            Controls.Add(txtCuil);
            Name = "frmRecuperar";
            Text = "frmRecuperar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCuil;
        private Label label1;
        private Button btnRecuperar;
        private Label lblId;
        private Label lblCuil;
        private Label lblNombre;
        private Label lblEmail;
        private Label lblSalario;
        private Label lblFechaIngreso;
        private Label lblAntiguedad;
    }
}