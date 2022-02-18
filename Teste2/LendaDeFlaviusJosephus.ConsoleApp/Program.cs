using System;

namespace LendaDeFlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parcial
            Console.WriteLine("Insira a quantidade de homens:");
            string strHomens = Console.ReadLine();
            int homens = Convert.ToInt32(strHomens);
            int[] arrayDeHomens = new int [homens];
            Console.WriteLine("Insira a quantidade de saltos");
            string strSaltos = Console.ReadLine();
            int saltos = Convert.ToInt32(strSaltos);

            int resultado = 0;

            for (int i = 0; i < arrayDeHomens.Length; i++)
            {
                resultado = (arrayDeHomens[0] + saltos) - 1;
                if(arrayDeHomens.Length == 1)
                {
                    break;
                }
            }
            Console.WriteLine("Caso:" + resultado);
        }
    }
}
