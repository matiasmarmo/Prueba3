using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
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

        private void btnok_Click(object sender, EventArgs e)
        {
            int velocidad;
            velocidad = Convert.ToInt16(txtvelocidad.Text);
            multas marmovich = new multas();
            marmovich.Calculo(velocidad);
            lblmulta.Text = marmovich.valor2;
        }
    }

    class multas
    {
        public string valor2;
        public string Calculo(int valor1)
        {
            
            if (valor1<60 || valor1>120 && valor1<=140)
            {
                valor2 = "300"; 
            }
            else if (valor1>140 && valor1<=180)
            {
                valor2 = "600";
            }
            else if (valor1>180)
            {
                valor2 = "1000";
            }
            else
            {
                valor2 = "0";
            }
            return valor2;
        }

    }
}
