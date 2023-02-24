using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora.Models
{
    public class Expresion
    {
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }



        public decimal Suma()
        {
            return Numero1 + Numero2;
        }
        public decimal Resta()
        {
            return Numero1 - Numero2;
        }
        public decimal Division()
        {
            return Numero1 / Numero2;
        }
        public decimal Multiplicacion()
        {
            return Numero1 * Numero2;
        }


        public  string Sumar()
        {
            return $"La Suma de los numeros es: {Suma()} ";
        }
        public string Restar()
        {
            return $"La resta de los numeros es: {Resta()} ";
        }
        public string Dividir()
        {
            return $"La division de los numeros es: {Division()} ";
        }
        public string Multiplicar()
        {
            return $"La multiplicacion de los numeros es: {Multiplicacion()} ";
        }

        public override string ToString()
        {
            return $"Hola mi nombre es y mi edad es: {Suma()} ";
        }

        
    }
}
