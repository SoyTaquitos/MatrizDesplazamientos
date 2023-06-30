using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizDesplazamientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Matriz m1;
        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matriz();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = m1.Descargar(); 
        }

        private void ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoPorFilas();
            textBox6.Text = m1.Descargar();
        }

        private void desplazamientoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoPorColumnas();
            textBox6.Text = m1.Descargar();
        }

        private void columnaDeArribaHaciaAbajoDerizqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoPorColumna2();
            textBox6.Text = m1.Descargar();
        }

        private void filaDerizqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoPorFila2();
            textBox6.Text = m1.Descargar();
        }

        private void filaInferiorIzqderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoPorFilaInfIzq();
            textBox6.Text = m1.Descargar();
        }

        private void colunaInferiorIzqderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoPorColumnaInfIzq();
            textBox6.Text = m1.Descargar();
        }

        private void filaInferiorDerizqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoPorFilaInfDer();
            textBox6.Text = m1.Descargar();
        }

        private void columnaInferiorDerizqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoPorColumnaInfDer();
            textBox6.Text = m1.Descargar();
        }

        private void diagonalPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DesplazamientoDiagonalPrincipal();
            textBox6.Text = m1.Descargar();
        }
    }
}
