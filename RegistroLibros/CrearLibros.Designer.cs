namespace RegistroLibros
{
    partial class CrearLibros
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
            btnRegistrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSize = true;
            btnRegistrar.Location = new Point(467, 301);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(80, 30);
            btnRegistrar.TabIndex = 23;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.Location = new Point(938, 439);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 30);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // CrearLibros
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 481);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Name = "CrearLibros";
            Text = "CrearLibros";
            Controls.SetChildIndex(txtTitulo, 0);
            Controls.SetChildIndex(txtEditorial, 0);
            Controls.SetChildIndex(txtAutor, 0);
            Controls.SetChildIndex(txtISBN, 0);
            Controls.SetChildIndex(txtPaginas, 0);
            Controls.SetChildIndex(btnRegistrar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnSalir;
    }
}