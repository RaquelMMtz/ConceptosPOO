using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculo v;
            v = new Vehiculo();
            v.Modelo = 2020;
            MessageBox.Show(v.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cuatrimoto m;
            m = new Cuatrimoto();
            m.Modelo = 2018;
            m.Marca = "Kawasaki";
            MessageBox.Show(m.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Camioneta c;
            c = new Camioneta();
            c.Modelo =  2019;
            c.Color = "Roja con lineas blancas";
            MessageBox.Show(c.ToString());
        }
    }
}
