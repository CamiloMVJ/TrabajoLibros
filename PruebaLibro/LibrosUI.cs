using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PruebaLibro.LibrosUI;

namespace PruebaLibro
{
    public partial class LibrosUI : Form
    {
        protected int CuentaTextBox = 5;
        public LibrosUI()
        {
            InitializeComponent();
        }

        public enum IndicesTextBox
        {
            TITULO,
            EDITORIAL,
            AUTOR,
            ISBN,
            PAGINAS
        }

        public void LimpiarTextBox()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i];
                if (miControl is TextBox)
                    miControl.Text = "";
            }
        }

        public void SetValoresTextBox(Libro info)
        {
            if (info == null)
            {
                throw new ArgumentException("No se ha podido leer el libro, Continue!");
            }
            else
            {
                txtTitulo.Text = info.Titulo;
                txtEditorial.Text = info.Editorial;
                txtAutor.Text = info.Autor;
                txtISBN.Text = info.Isbn;
                txtPaginas.Text = info.Paginas.ToString();
            }
        }
    }
}
