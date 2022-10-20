using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaLogica
{
    public class Logica
    {
        //atributos
        private decimal num1;
        private decimal num2;
        private string operador;
        private decimal resultado = 0;

        //metodo para calcular la suma de numeros digitados por el usuario
        public decimal calcularSuma(decimal valor1, decimal valor2)
        {
            //decimal resultado = 0;
            resultado = valor1 + valor2;
            return resultado;
        }

        //metodo para calcular la resta de numeros digitados por el usuario
        public decimal calcularResta(decimal valor1, decimal valor2)
        {
            //decimal resultado = 0;
            resultado = valor1 - valor2;
            return resultado;
        }

        //metodo para calcular la multiplicacion de numeros digitados por el usuario
        public decimal calcularMulti(decimal valor1, decimal valor2)
        {
            //decimal resultado = 0;
            resultado = valor1 * valor2;
            return resultado;
        }

        //metodo para calcular la division de numeros digitados por el usuario
        public decimal calcularDivision(decimal valor1, decimal valor2)
        {
            //decimal resultado = 0;
            resultado = valor1 / valor2;
            return resultado;
        }

        //metodo para calcular la raiz de numeros digitados por el usuario
        public double calcularRaiz(double valor1)
        {
            double resultado = 0;
            resultado = Math.Sqrt(valor1); // obtiene la raiz cuadrada de los numeros digitados por el usuario
            return resultado;
        }


        //metodo para calcular el numero elevado al cuadrado 
        public decimal calcularElevadoCuadrado(decimal valor1)
        {
            //decimal resultado = 0;
            resultado = valor1 * valor1;
            return resultado;
        }

        //metodo para cambiar el signo del numero digitado por el usuario
        public decimal cambiarSignos(decimal valor)
        {
            //decimal resultado = 0;
            resultado = valor *= -1;
            return resultado;
        }

        //metodo para borrar el ultimo digito del resultado en pantalla
        public string borrarNumero(string valor)
        {
            string resultado = "";
            resultado = valor.Remove(valor.Length - 1, 1);// Remove sirve para remover caracteres en una cadena (al pasarla parametros la extension de la cadena -1 y de 1 en 1)
            return resultado;
        }

        //metodo para limpiar por completo la pantalla de la calculadora
        public string borrarPantalla(string texto)
        {
            string resul = "";
            resul = texto = string.Empty;
            return resul;
        }

    }
}
