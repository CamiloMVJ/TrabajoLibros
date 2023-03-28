namespace PruebaLibro
{
    partial class LibrosUI
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
            label5 = new Label();
            txtPaginas = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            label3 = new Label();
            txtAutor = new TextBox();
            label2 = new Label();
            txtEditorial = new TextBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(867, 61);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 21;
            label5.Text = "Paginas";
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(836, 85);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(126, 27);
            txtPaginas.TabIndex = 20;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(703, 61);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(42, 20);
            lblISBN.TabIndex = 19;
            lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(672, 85);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(126, 27);
            txtISBN.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 61);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 17;
            label3.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(483, 85);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(126, 27);
            txtAutor.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 61);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 15;
            label2.Text = "Editorial";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(291, 85);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(126, 27);
            txtEditorial.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 61);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 13;
            label1.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(83, 85);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(126, 27);
            txtTitulo.TabIndex = 12;
            // 
            // LibrosUI
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 474);
            Controls.Add(label5);
            Controls.Add(txtPaginas);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Controls.Add(label3);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtEditorial);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "LibrosUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibrosUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label lblISBN;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtPaginas;
        public TextBox txtISBN;
        public TextBox txtAutor;
        public TextBox txtEditorial;
        public TextBox txtTitulo;
    }
}