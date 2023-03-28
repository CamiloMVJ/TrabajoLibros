using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLibro
{
    public class Libro
    {
        private string isbn;
        private string autor;
        private string editorial;
        private string titulo;
        private int paginas;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Paginas { get => paginas; set => paginas = value; }

        public Libro(string titulo, string editorial, string autor, string isbn, int paginas)
        {
            Titulo = titulo;
            Editorial = editorial;
            Autor = autor;
            Isbn = isbn;
            Paginas = paginas;
        }

        public Libro() : this("", "", "", "", 0) { }

        public override string ToString()
        {
            return string.Format("Libro: {0} \nAutor: {1} \nEditorial: {2} \nISBN: {3} \nPaginas: {4}", titulo,autor, editorial, isbn, paginas);
        }
    }
}
