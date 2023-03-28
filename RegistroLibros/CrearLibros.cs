using PruebaLibro;
using System.Text.Json;


namespace RegistroLibros
{
    public partial class CrearLibros : LibrosUI
    {
        public CrearLibros()
        {
            InitializeComponent();
        }
        string filename = "";
        string jsonstring = "";
        List<Libro> libros = new List<Libro>();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    jsonstring = File.ReadAllText(filename);
            //    libros = (List<Libro>)JsonSerializer.Deserialize<List<Libro>>(jsonstring);

            //}
            //catch (JsonException)
            //{
            //    //MessageBox.Show("No se puede leer el archivo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (IOException)
            //{

            //}

            if (filename.Trim().Length > 0)
            {
                jsonstring = File.ReadAllText(filename);
                libros = (List<Libro>)JsonSerializer.Deserialize<List<Libro>>(jsonstring);
                string titulo = txtTitulo.Text;
                string editorial = txtEditorial.Text;
                string autor = txtAutor.Text;
                string isbn = txtISBN.Text;
                int paginas = 0;
                try
                {
                    paginas = int.Parse(txtPaginas.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de paginas no es un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    filename = "";
                    return;
                }
                libros.Add(new Libro(titulo, editorial, autor, isbn, paginas));
                try
                {
                    jsonstring = JsonSerializer.Serialize(libros);
                    File.WriteAllText(filename, jsonstring);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo Serializar la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    filename = "";
                    return;
                }
                MessageBox.Show("Libro Registrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox();
            }
            else if (filename == "")
            {
                SaveFileDialog guardarcomo = new SaveFileDialog();
                guardarcomo.CheckFileExists = false;
                guardarcomo.AddExtension = true;
                guardarcomo.OverwritePrompt = false;
                guardarcomo.Filter = "Text File | *.json";
                guardarcomo.DefaultExt = "json";
                DialogResult resultado = guardarcomo.ShowDialog();
                if (resultado == DialogResult.Cancel)
                    return;

                filename = guardarcomo.FileName;
                bool existe = File.Exists(filename);
                if (existe)
                {
                    try
                    {
                        DialogResult pregunta = MessageBox.Show("¿Desea agregar mas informacion al archivo?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(pregunta == DialogResult.Yes)
                        {
                            jsonstring = File.ReadAllText(filename);
                            libros = (List<Libro>)JsonSerializer.Deserialize<List<Libro>>(jsonstring);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                string titulo = txtTitulo.Text;
                string editorial = txtEditorial.Text;
                string autor = txtAutor.Text;
                string isbn = txtISBN.Text;
                int paginas = 0;
                try
                {
                    paginas = int.Parse(txtPaginas.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de paginas no es un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPaginas.Focus();
                    filename = "";
                    return;
                }
                libros.Add(new Libro(titulo, editorial, autor, isbn, paginas));
                jsonstring = JsonSerializer.Serialize(libros);
                File.WriteAllText(filename, jsonstring);
                MessageBox.Show("Libro Registrado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox();
            }

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