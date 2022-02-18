using System;

namespace LendaDeFlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não terminado
            Console.WriteLine("Insira a quantidade de homens:");
            string strHomens = Console.ReadLine();
            int homens = Convert.ToInt32(strHomens);
            Console.WriteLine("Insira a quantidade de saltos");
            string strSaltos = Console.ReadLine();
            int saltos = Convert.ToInt32(strSaltos);

            int resultado = 0;
            while(homens == 1)
            {
                resultado = (homens / saltos) - 1;
            }
            //for(int i = 0; i < homens; i++)
            //{
                
            //}
            Console.WriteLine("Caso:" + resultado);
        }
    }
}
