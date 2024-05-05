using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace practicoVectores2
{
    public partial class Form1 : Form
    {
        classVector vec1, vec2, vec3, vec4;

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Concat(vec1.descargar());
        }

        private void cargarElexEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cant, ter;
            vec1 = new classVector();
            cant = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for(ter = 1; ter <= cant; ter++)
            {
                vec1.cargarElexEle(int.Parse(Interaction.InputBox("ingrese los elementos: " + ter)));
            }
        }

        private void fIbonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.fibonacci(int.Parse(textBox1.Text));
            textBox4.Text = vec1.descargar();
        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.fibonaccInvertir(int.Parse(textBox1.Text));
            textBox4.Text = vec1.descargar();
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(vec1.fraccionFibonacci(int.Parse(textBox1.Text)));
        }

        private void pregunta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(vec1.elementoMayor(int.Parse(textBox1.Text)));
        }

        private void pregunta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(vec1.multiplosPosicion(int.Parse(textBox1.Text)));
        }

        private void pregunta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.multiplsoNoMultiplos(int.Parse(textBox1.Text), ref vec2, ref vec3);
            textBox5.Text = vec2.descargar();
            textBox6.Text = vec3.descargar();
        }

        private void pregunta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.invertirVector();
            textBox5.Text = vec1.descargar();
        }

        private void pregunta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(vec1.elementosIguales());
        }

        private void pregunta10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(vec1.segmentoOrdenado(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
        }

        private void busquedaElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(vec1.busqueSecuencial(int.Parse(textBox1.Text)));
        }

        private void pregunta9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.unioElementos(vec2, ref vec3);
            textBox6.Text = vec3.descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec2.cargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vec3.cargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = vec2.descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = vec3.descargar();
        }

        private void cargarElexEleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cant, ter;
            vec2 = new classVector();
            cant = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for (ter = 1; ter <= cant; ter++)
            {
                vec2.cargarElexEle(int.Parse(Interaction.InputBox("ingrese los elementos: " + ter)));
            }
        }

        private void cargarElexEleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int cant, ter;
            vec3 = new classVector();
            cant = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for (ter = 1; ter <= cant; ter++)
            {
                vec3.cargarElexEle(int.Parse(Interaction.InputBox("ingrese los elementos: " + ter)));
            }
        }

        private void pregunta9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec1.diferenciaElementos(vec2, ref vec3);
            textBox6.Text = vec3.descargar();
        }

        private void pregunta1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec1.elimElemNoPrimos();
            textBox5.Text = vec1.descargar();
        }

        private void pregunta2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec1.ordenElemPos(int.Parse(textBox1.Text));
            textBox5.Text = vec1.descargar();
        }

        private void ordenBurbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.ordenamientoBurbuja();
            textBox5.Text = vec1.descargar();
        }

        private void ordenIntercambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.ordenIntercambio();
            textBox5.Text = vec1.descargar();
        }

        private void pregunta2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vec1.ordenEspiral();
            textBox5.Text = vec1.descargar();
        }

        private void pregunta4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(vec1.contElemDiferent(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
        }

        private void pregunta5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec1.encontrarElemRepetido(int.Parse(textBox1.Text), int.Parse(textBox2.Text), ref vec2, ref vec3);
            textBox5.Text = vec2.descargar();
            textBox6.Text = vec3.descargar();
        }

        private void pregunta6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec1.encontrarFrecuElem(int.Parse(textBox1.Text), int.Parse(textBox2.Text), ref vec2, ref vec3);
            textBox5.Text = vec2.descargar();
            textBox6.Text = vec3.descargar();
        }

        private void pregunta7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec1.elemFrecuFibonacci(ref vec2, ref vec3);
            textBox5.Text = vec2.descargar();
            textBox6.Text = vec3.descargar();
        }

        private void pregunta8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.segmentarElemRepYNoRep(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = vec1.descargar();
        }

        private void pregunta9ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vec1.segmentarCapicuasNoCapicuas();
            textBox5.Text = vec1.descargar();
        }

        private void pregunta10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec1.intercalarPrimYNoPirm(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = vec1.descargar();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.cargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vec1 = new classVector();
            vec2 = new classVector();
            vec3 = new classVector();
            vec4 = new classVector();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
