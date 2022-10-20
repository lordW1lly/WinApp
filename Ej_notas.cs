using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Ej_notas : Form
    {
        public Ej_notas()
        {
            InitializeComponent();
        }

        private void Ej_notas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            decimal notaUno = Convert.ToDecimal(txtNotaUno.Text);
            decimal notaDos = Convert.ToDecimal(txtNotaDos.Text);
            decimal notaTres = Convert.ToDecimal(txtNotaTres.Text);
            decimal promedio = (notaUno + notaDos + notaTres) / 3;
            string NotaAlta = "";
            string mensajePromedio = "";

            if (notaUno > notaDos && notaUno > notaTres)
            {
                NotaAlta = txtNotaUno.Text;
            }
            else if (notaDos > notaTres && notaDos > notaUno)
            {
                NotaAlta = txtNotaDos.Text; ;
            }
            else if (notaTres > notaUno && notaTres > notaDos)
            {
                NotaAlta = txtNotaTres.Text;
            }

            if (promedio <= 4)
            {
                mensajePromedio = "En proceso de aprendizaje";
            }
            else if (promedio < 7)
            {
                mensajePromedio = "Regular";
            }
            else if (7 <= promedio && promedio < 9)
            {
                mensajePromedio = "Muy Bien";
            }

            MessageBox.Show("tu nota mas alta fue: " + NotaAlta + ", tu promedio fue: " + promedio+ ". "+ mensajePromedio+"!");
        }
    }
}
