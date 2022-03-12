using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaLogica;

namespace InterfazGrafica
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

       /* Logica myLogica = new Logica();
        //private Logica myLogica;

        decimal num1, num2, Memory;
        double num3;
        string operacion;
        decimal resultado = 0;
        bool bandera = true;

        private void btnAgrega3Ceros_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "000";
        }

        private void btnAgrega2Ceros_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "00";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
            //string captura = txtPantalla.Text;
           // txtPantalla.Text = captura;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
          // /*string captura2 = txtPantalla.Text;
            txtPantalla.Text = captura2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ",";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = Convert.ToDecimal(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "x";
            num1 = Convert.ToDecimal(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = Convert.ToDecimal(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            //num1 += Convert.ToDecimal(txtPantalla.Text);
            num1 = Convert.ToDecimal(txtPantalla.Text);
            txtPantalla.Clear();
            //calcularOperacion();

        }

        private void btnElevado2_Click(object sender, EventArgs e)
        {
            operacion = "^";
            num1 = Convert.ToDecimal(txtPantalla.Text);
            bandera = false;
            txtPantalla.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operacion = "√";
            num3 = Convert.ToDouble(txtPantalla.Text);

            if (num1 >= 0)
            {
                bandera = false;
                txtPantalla.Clear();
            }
            else
            {
                txtPantalla.Text = "Error, intente de nuevo!!";
            }
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtPantalla.Text);
            num1 *= -1;
            txtPantalla.Text = num1.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = string.Empty;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length > 1)
            {
                txtPantalla.Text = txtPantalla.Text.Remove(txtPantalla.Text.Length - 1, 1);// Remove sirve para remover caracteres en una cadena (al pasarla parametros la extension de la cadena -1 y de 1 en 1)
            }
            else
            {
                txtPantalla.Clear();
            }     
         }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Logica myLogica = new Logica();
            calcularOperacion();   
        }

         private void calcularOperacion()
         {
            if (bandera == true)
            {
                num2 = Convert.ToDecimal(txtPantalla.Text);
            }
            
            
            switch (operacion)
            {

                case "+":
                    decimal resultado = myLogica.calcularSuma(num1, num2);
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "-":
                    decimal resultado1 = myLogica.calcularResta(num1, num2);
                    txtPantalla.Text = resultado1.ToString();
                    break;

                case "x":
                    decimal resultado2 = myLogica.calcularMulti(num1, num2);
                    txtPantalla.Text = resultado2.ToString();
                    break;

                case "/":
                    decimal resultado3 = myLogica.calcularDivision(num1, num2);
                    txtPantalla.Text = resultado3.ToString();
                    break;

                case "^":
                    decimal resultado4 = myLogica.calcularElevadoCuadrado(num1);
                    txtPantalla.Text = resultado4.ToString();
                    break;

                case "√":
                    double resultado5 = myLogica.calcularRaiz(num3);
                    txtPantalla.Text = resultado5.ToString();
                    break;

                case "+-":
                    decimal resultado6 = myLogica.calcularSuma(num1, num2);
                    txtPantalla.Text = resultado6.ToString();
                    break;
            }

            bandera = true;
        }*/

    }
}
