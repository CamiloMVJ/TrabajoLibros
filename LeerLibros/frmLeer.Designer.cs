namespace LeerLibros
{
    partial class frmLeer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.AutoSize = true;
            btnSiguiente.Location = new Point(442, 321);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(120, 30);
            btnSiguiente.TabIndex = 23;
            btnSiguiente.Text = "Abrir Registros";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // frmLeer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 472);
            Controls.Add(btnSiguiente);
            Name = "frmLeer";
            Text = "Form1";
            Load += frmLeer_Load;
            Controls.SetChildIndex(txtTitulo, 0);
            Controls.SetChildIndex(txtEditorial, 0);
            Controls.SetChildIndex(txtAutor, 0);
            Controls.SetChildIndex(txtISBN, 0);
            Controls.SetChildIndex(txtPaginas, 0);
            Controls.SetChildIndex(btnSiguiente, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiguiente;
    }
}