namespace Escritorio
{
    partial class frmListado
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
            dgvDocentes = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            SuspendLayout();
            // 
            // dgvDocentes
            // 
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Location = new Point(12, 107);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.RowTemplate.Height = 29;
            dgvDocentes.Size = new Size(776, 254);
            dgvDocentes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 67);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Listado de Docentes";
            // 
            // frmListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvDocentes);
            Name = "frmListado";
            Text = "frmListado";
            Load += frmListado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDocentes;
        private Label label1;
    }
}