﻿using System;
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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            // Abre el formulario Form3
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // Oculta el formulario actual
        }
    }
}
