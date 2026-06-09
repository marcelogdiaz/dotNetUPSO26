using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S11_FORMS
{
    //Este es el archivo editable de nuestro FORMULARIO

    public partial class FormPpal : Form
    {
        int cantidadClicks = 1;
        public FormPpal()
        {
            InitializeComponent();
        }

        private void buttonCambiarTitulo_Click(object sender, EventArgs e)
        {
            this.Text = textBoxTitulo.Text;
            //cantidadClicks++;
        }

        private void buttonCambiarTitulo_Enter(object sender, EventArgs e)
        {
            labelBoton.Text = "Ingresé al foco del BOTON";
        }

        private void buttonCambiarTitulo_Leave(object sender, EventArgs e)
        {
            labelBoton.Text = "Salí del foco del BOTON";
        }

        private void buttonCambiarTitulo_MouseHover(object sender, EventArgs e)
        {
            labelBoton.Text = "Hover dentro del BOTON";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ) {
                labelCheckbox.Text = "El checkbox esta tildado";
            }
            else {
                labelCheckbox.Text = "El checkbox NO esta tildado";
            } 
        }
    }
}
