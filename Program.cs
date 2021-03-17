using System;

namespace Ex_4N_01
{
    class Program
    {
        public static double captura()
        {
            double valor1, valor2, valor3, menor;
            double media;

            Console.Write("Digite a 1º nota: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a 2º nota: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a 3º nota: ");
            valor3 = Convert.ToInt32(Console.ReadLine());

            menor = valor1;

            if (valor2 < menor)
                menor = valor2;

            if (valor3 < menor)
                menor = valor3;

            media = (valor1 + valor2 + valor3 - menor) / 2.0;
            Console.Write("Média: {0}\n\n", media.ToString());

            return media;
        }


        static void Main(string[] args)
        {
            double media_aluno;

            media_aluno= Program.captura();

            if( media_aluno >= 6.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
