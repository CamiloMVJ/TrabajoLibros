using PruebaLibro;
using System.Text.Json;

namespace LeerLibros
{
    public partial class frmLeer : LibrosUI
    {
        string jsonstring = "";
        string filename = "libros.json";
        List<Libro> libros = new List<Libro>();
        int cantidad = 0;
        public frmLeer()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (btnSiguiente.Text.Equals("Abrir Registros"))
            {
                btnSiguiente.Text = "Siguiente";
            }
            else if (btnSiguiente.Text.Equals("Siguiente"))
            {
                if (cantidad >= 0)
                {
                    SetValoresTextBox(libros[cantidad]);
                    cantidad--;
                }
                else
                {
                    MessageBox.Show("No hay mas libros en el registro, Volviendo al primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarTextBox();
                    cantidad = libros.Count - 1;
                }
            }

        }

        private void frmLeer_Load(object sender, EventArgs e)
        {
            try
            {
                jsonstring = File.ReadAllText("H:\\PruebaLibro\\RegistroLibros\\ArchivosCompartidos\\libros.json");
                libros = (List<Libro>)JsonSerializer.Deserialize<List<Libro>>(jsonstring);
                cantidad = libros.Count - 1;
            }
            catch (Exception)
            {

            }
        }
    }
}
