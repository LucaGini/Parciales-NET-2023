namespace Escritorio
{
    partial class frmAbmUsuario
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
            dgvUsuarios = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUserType = new TextBox();
            btnCancelar = new Button();
            btnAdd = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            label5 = new Label();
            txtFilterUsername = new TextBox();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 35);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 29;
            dgvUsuarios.Size = new Size(469, 201);
            dgvUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 35);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 81);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 130);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 3;
            label3.Text = "Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 178);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 4;
            label4.Text = "Tipo Usuario";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(649, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(188, 27);
            txtUsername.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(649, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(649, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUserType
            // 
            txtUserType.Location = new Point(649, 178);
            txtUserType.Name = "txtUserType";
            txtUserType.Size = new Size(188, 27);
            txtUserType.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(195, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(361, 373);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(694, 373);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Eliminar";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(527, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 289);
            label5.Name = "label5";
            label5.Size = new Size(183, 20);
            label5.TabIndex = 14;
            label5.Text = "Filtrar por NombreUsuario";
            // 
            // txtFilterUsername
            // 
            txtFilterUsername.Location = new Point(219, 286);
            txtFilterUsername.Name = "txtFilterUsername";
            txtFilterUsername.Size = new Size(188, 27);
            txtFilterUsername.TabIndex = 15;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(442, 284);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 16;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // frmAbmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(btnFilter);
            Controls.Add(txtFilterUsername);
            Controls.Add(label5);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnCancelar);
            Controls.Add(txtUserType);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "frmAbmUsuario";
            Text = "frmAbmUsuario";
            Load += frmAbmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUserType;
        private Button btnCancelar;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnUpdate;
        private Label label5;
        private TextBox txtFilterUsername;
        private Button btnFilter;
    }
}