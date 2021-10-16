using System;

namespace MediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            double media;
            double mediaNova;
            double exame;


            Console.WriteLine("Digite o valor da sua primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da sua segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da sua terceira nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            media = (n1 * n2 * n3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Digite o valor da nota do exame:");
                exame = Convert.ToDouble(Console.ReadLine());

                mediaNova = (exame * media) / 2;

                if(mediaNova >= 5)
                {
                    Console.WriteLine("Aprovado em exame");
                } else
                {
                    Console.WriteLine("Reprovado");
                    Console.WriteLine("Sua media foi de {0}", mediaNova);
                }
            }
        }
    }
}
