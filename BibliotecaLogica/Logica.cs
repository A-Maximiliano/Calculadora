using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaLogica
{
    public class Logica
    {
        public decimal calcularSuma(decimal valor1, decimal valor2)
        {
            decimal resultado = 0;
            resultado = valor1 + valor2;
            return resultado;
        }

        public decimal calcularResta(decimal valor1, decimal valor2)
        {
            decimal resultado = 0;
            resultado = valor1 - valor2;
            return resultado;
        }

        public decimal calcularMulti(decimal valor1, decimal valor2)
        {
            decimal resultado = 0;
            resultado = valor1 * valor2;
            return resultado;
        }

        public decimal calcularDivision(decimal valor1, decimal valor2)
        {
            decimal resultado = 0;
            resultado = valor1 / valor2;
            return resultado;
        }

        public double calcularRaiz(double valor1)
        {
            double resultado = 0;
            resultado = Math.Sqrt(valor1);
            return resultado;
        }

        public decimal calcularElevadoCuadrado(decimal valor1)
        {
            decimal resultado = 0;
            resultado = valor1 * valor1;
            return resultado;
        }

        public void cambiarSignos()
        {
            decimal resultado = 0;
            //return resultado;
        }

        public void borrarNumero()
        {
            decimal resultado = 0;
            //return resultado;
        }

        public void borrarPantalla()
        {
            decimal resultado = 0;
            //return resultado;
        }

    }
}
