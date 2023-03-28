using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLibros
{
    public partial class Inicio : Form
    {
        CrearLibros Crear;
        LeerLibros Leer;
        public Inicio()
        {
            InitializeComponent();
            Crear = new CrearLibros();
            Leer = new LeerLibros();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crear.ShowDialog();
            this.Show();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leer.ShowDialog();
            this.Show();
        }
    }
}
