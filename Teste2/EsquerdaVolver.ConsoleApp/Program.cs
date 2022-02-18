using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Terminado
            Console.WriteLine("Informe o número de comandos emitidos pelo sargento:");
            string strNumeroDeComandos = Console.ReadLine();
            int numeroDeComandos = Convert.ToInt32(strNumeroDeComandos);
            Console.WriteLine("Insira as direções informadas pelo sargento:");
            string strDirecao = Console.ReadLine();
            char[] direcao = strDirecao.ToCharArray();

            char frente = 'N';


            for (int i = 0; i < numeroDeComandos; i++)
            {
                if (direcao[i] == 'D')
                {
                    if (frente == 'N')
                    {
                        frente = 'L';
                    }
                    else if (frente == 'L')
                    {
                        frente = 'S';
                    }
                    else if (frente == 'S')
                    {
                        frente = 'O';
                    }
                    else if (frente == 'O')
                    {
                        frente = 'N';
                    }
                }
                if(direcao[i] == 'E')
                {
                    if (frente == 'N')
                    {
                        frente = 'O';
                    }
                    else if (frente == 'O')
                    {
                        frente = 'S';
                    }
                    else if (frente == 'S')
                    {
                        frente = 'L';
                    }
                    else if (frente == 'L')
                    {
                        frente = 'N';
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("=====");
            Console.WriteLine(frente);
            Console.WriteLine("=====");
        }
    }
}
