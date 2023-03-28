using PruebaLibro;
using System.Text.Json;

namespace RegistroLibros
{
    public partial class LeerLibros : LibrosUI
    {
        string jsonstring = "";
        string filename = "libros.json";
        List<Libro> libros = new List<Libro>();
        int cantidad = 0;

        public LeerLibros()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (btnSiguiente.Text.Equals("Siguiente"))
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
            else if(btnSiguiente.Text.Equals("Abrir Registros"))
            {
                OpenFileDialog selector = new OpenFileDialog();
                DialogResult result = selector.ShowDialog();
                string filename;
                if (result == DialogResult.Cancel)
                    return;
                filename = selector.FileName;


                if (filename == "" || filename == null)
                    MessageBox.Show("Nombre del archivo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    try
                    {
                        jsonstring = File.ReadAllText(filename);
                        libros = (List<Libro>)JsonSerializer.Deserialize<List<Libro>>(jsonstring);
                        cantidad = libros.Count - 1;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No es posible leer ese archivo, porfavor ingrese un archivo JSON con informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btnSiguiente.Text = "Siguiente";
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
            
        }

        private void LeerLibros_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vuelva pronto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Inicio menu = new Inicio();
            this.Close();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
