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
    public partial class CalculadoraPrincipal : Form
    {
        public CalculadoraPrincipal()
        {
            InitializeComponent();
        }


        Logica myLogica = new Logica();
        //private Logica myLogica;

        //variables globales
        decimal num1, num2, Memory;
        double num3;
        string operacion;
        decimal resultado = 0;
        bool bandera = true;
        bool bandera2 = true;

        //evento del boton que agrega un cero en pantalla(textbox)
        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        //evento del boton que agrega el numero 1 en pantalla(textbox)
        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        //evento del boton que agrega el numero 2 en pantalla(textbox)
        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        //evento del boton que agrega el numero 3 en pantalla(textbox)
        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        //evento del boton que agrega el numero 4 en pantalla(textbox)
        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        //evento del boton que agrega el numero 5 en pantalla(textbox)
        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        //evento del boton que agrega el numero 6 en pantalla(textbox)
        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        //evento del boton que agrega el numero 7 en pantalla(textbox)
        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        //evento del boton que agrega el numero 8 en pantalla (textbox)
        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        //evento del boton que agrega el numero 9 en pantalla (textbox)
        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        //evento que permite sumar los numeros ingresados por el usuario
        private void btnSuma_Click(object sender, EventArgs e)
        {
            ValidarIngreso();
            if (bandera2 == true)
            {
                operacion = "+";
                //num1 += Convert.ToDecimal(txtPantalla.Text);
                num1 = Convert.ToDecimal(txtPantalla.Text);
                txtPantalla.Clear();
                //calcularOperacion();
            }
            bandera2 = true;
        }

        //evento que permite restar los numeros ingresados por el usuario
        private void btnResta_Click(object sender, EventArgs e)
        {
            ValidarIngreso();
            if (bandera2 == true)
            {              
                operacion = "-";
                num1 = Convert.ToDecimal(txtPantalla.Text);
                txtPantalla.Clear();
            }
            bandera2 = true;
        }

        //evento que permite multiplicar los numeros ingresados por el usuario
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            ValidarIngreso();
            if (bandera2 == true)
            {              
                operacion = "x";
                num1 = Convert.ToDecimal(txtPantalla.Text);
                txtPantalla.Clear();
            }
            bandera2 = true;
        }

        //evento que permite dividir los numeros ingresados por el usuario
        private void btnDivision_Click(object sender, EventArgs e)
        {
            ValidarIngreso();
            if (bandera2 == true)
            {
                operacion = "/";
                num1 = Convert.ToDecimal(txtPantalla.Text);
                txtPantalla.Clear();
            }
            bandera2 = true;
        }

        //evento que permite elevar un numero ingresado por el usuario
        private void btnElevado2_Click(object sender, EventArgs e)
        {
            ValidarIngreso();
            if (bandera2 == true)
            {
                operacion = "^";
                num1 = Convert.ToDecimal(txtPantalla.Text);
                txtPantalla.Clear();
                bandera = false;
            }
            bandera2 = true;         
        }

        //evento que permite agregar decimales a un numero
        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ",";
        }

        //evento que permite cambiar el signo del numero mostrado en pantalla
        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            ValidarIngreso();
            if (bandera2 == true)
            {
                num1 = Convert.ToDecimal(txtPantalla.Text);
                num1 *= -1;
                txtPantalla.Text = num1.ToString();
            }
            bandera2 = true;
        }

        //evento del boton que permite sacar la raiz del numero digitado
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            ValidarIngreso();
            if (bandera2 == true)
            {
                operacion = "√";
                num3 = Convert.ToDouble(txtPantalla.Text);

                if (num1 >= 0) //valida que el numero ingresado sea maoyr que cero
                {
                    bandera = false;
                    txtPantalla.Clear();
                }
                else
                {
                    txtPantalla.Text = "Error, intente de nuevo!!";
                }
            }
            bandera2 = true;
            
        }

        //evento que permite eliminar el ultimo digito del resultado en pantalla
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

        //Evento click para limpiar toda la pantalla
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = string.Empty;
        }

        //Evento que llama a un metodo para realizar la operacion la eleccion del usuario
        private void btnIgual_Click(object sender, EventArgs e)
        {
            calcularOperacion();
        }

        //evento del boton que agrega 2 ceros en pantalla
        private void btnAgrega2Ceros_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "00";
        }

        //evento del boton que agrega 3 ceros en pantalla
        private void btnAgrega3Ceros_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "000";
        }

        //metodo que valida el ingreso de un numero para iniciar con la operacion seleccionada por el usuario
        private void ValidarIngreso()
        {
            if (txtPantalla.Text == string.Empty || txtPantalla.Text == ",")
            {
                MessageBox.Show("Favor ingresar una cantidad para continuar con la operación");
                bandera2 = false;
            }
        }
            
        //metod que realiza la operacion seleccionada por el usuario
        private void calcularOperacion()
        {
            try
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
            }

            catch (Exception ex)
            {
                MessageBox.Show("Favor realizar una operación");
            }
        }  
    }
}
