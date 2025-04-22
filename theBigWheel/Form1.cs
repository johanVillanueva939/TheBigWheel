using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theBigWheel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para manejar el evento Click del botón Configuración
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            // Lógica para abrir Form2
            Form2 configuracionForm = new Form2();
            configuracionForm.Show();
        }

        // Método para manejar el evento Load del formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes agregar lógica aquí si es necesario
        }
    }
}
