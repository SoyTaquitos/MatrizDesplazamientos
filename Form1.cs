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
        Matriz m1,m2;
        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matriz();
            m2 = new Matriz();
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
            m1.DiagonalPrincipal();
            textBox6.Text = m1.Descargar();
        }

        private void diagonalPrincipalDerizqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DiagonalPrincipal2();
            textBox6.Text = m1.Descargar();
        }

        private void diagonalSecundariaDerizqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DiagonalSecundaria();
            textBox6.Text = m1.Descargar();
        }

        private void diagonalSecundariaIzqderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.DiagonalSecundaria2();
            textBox6.Text = m1.Descargar();
        }

        private void triangularInferiorIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.TriangulInfIzq();
            textBox6.Text = m1.Descargar();
        }
        private void ordenamientoDeMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.OrdenamientoDeMatriz();
            textBox6.Text = m2.Descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void ordeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.OrdenamientoColumna();
            textBox6.Text = m2.Descargar();
        }

        private void senToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.OrdenSen();
            textBox6.Text = m2.Descargar();
        }

        private void triInfDErToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m2.OrdenamientoTriangularInferiorDererecha();
            textBox6.Text = m2.Descargar();
        }

        private void triangularInferiorDerecha2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox7.Text = m2.Descargar();
        }
    }
}
