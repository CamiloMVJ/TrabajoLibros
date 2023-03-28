namespace RegistroLibros
{
    partial class LeerLibros
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
            btnSiguiente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.AutoSize = true;
            btnSiguiente.Location = new Point(442, 322);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(120, 30);
            btnSiguiente.TabIndex = 24;
            btnSiguiente.Text = "Abrir Registros";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.Location = new Point(960, 437);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 30);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // LeerLibros
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 479);
            Controls.Add(btnSalir);
            Controls.Add(btnSiguiente);
            Name = "LeerLibros";
            Text = "LeerLibros";
            Load += LeerLibros_Load;
            Controls.SetChildIndex(txtTitulo, 0);
            Controls.SetChildIndex(txtEditorial, 0);
            Controls.SetChildIndex(txtAutor, 0);
            Controls.SetChildIndex(txtISBN, 0);
            Controls.SetChildIndex(txtPaginas, 0);
            Controls.SetChildIndex(btnSiguiente, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiguiente;
        private Button btnSalir;
    }
}