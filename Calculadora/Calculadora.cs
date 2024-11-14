using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora4
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string Data;

        public Calculadora (string Data)
        {
            ListaHistorico = new List<string>();
            this.Data = Data;
        }

        public int Somar (int num1, int num2)
        {
            int result = num1 + num2;

            ListaHistorico.Insert(0, "Resultado: " + result + " - Data: " + Data);

            return result;
        }

        public int Subtrair (int num1, int num2)
        {
            int result = num1 - num2;

            ListaHistorico.Insert(0, "Resultado: " + result + " - Data: " + Data);

            return result;        
        }

        public int Multiplicar (int num1, int num2)
        {
            int result = num1 * num2;

            ListaHistorico.Insert(0, "Resultado: " + result + " - Data: " + Data);

            return result;
        }

        public int Dividir (int num1, int num2)
        {
            int result = num1 / num2;

            ListaHistorico.Insert(0, "Resultado: " + result + " - Data: " + Data);

            return result;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count() - 3);
            return ListaHistorico;
        }
    }
}