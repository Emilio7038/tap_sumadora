using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumadora
{
    public partial class Form1 : Form
    {
        //variables globales
        
        List<int> resultadosint = new List<int> ();
        StringBuilder resultados = new StringBuilder();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void resultadosbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(valores.Text)){
                MessageBox.Show("El campo no debe ser vacio");
            }
            else if (valores.Text.ToLower().Contains("sumar"))
            {
                resultados.Append(valores.Text);
                resultados.Append(" El resultado de la suma es: " + obtenerSuma());
                resultados.Append("\r\n");

            }else if (valores.Text.ToLower().Contains("restar"))
            {
                resultados.Append(valores.Text);
                resultados.Append(" El resultado de la resta es: " + obtenerResta());
                resultados.Append("\r\n");
            }
            else
            {
                resultados.Append(valores.Text + "\r\n");
                if (esNumero(valores.Text))
                {
                    resultadosint.Add(obtenernumeroEntero(valores.Text));
                }
            }
            resultadosbox.Text = resultados.ToString();
            valores.Text = string.Empty;
        }
        private bool esNumero (string text)
        {
            int i = 0;
            bool result = int.TryParse(text, out i);
            return result;
        }

        private int obtenernumeroEntero(string text)
        {
            int i = 0;
            int.TryParse(text, out i);
            return i;
        }
        private double obtenerSuma()
        {
            double suma = 0.0;
            for (int i = 0; i < resultadosint.Count(); i++)
            {
                suma += resultadosint.ElementAt(i);

            }

            return suma;
        }

        private double obtenerResta()
        {
            double resta =resultadosint.First();
            for (int i = 1; i < resultadosint.Count(); i++)
            {
                resta -= resultadosint.ElementAt(i);

            }

            return resta;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            resultadosint.Clear();
            resultados.Clear();

            resultadosbox.Text = string.Empty;
        }
    }
}

