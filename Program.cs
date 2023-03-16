//  Elabore um algoritmo que calcule a idade média de 5 alunos.

using System;

namespace IdadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade de 5 alunos para encontrarmos a média de idade entre eles.");
            Console.WriteLine("Idade do primeiro aluno");
            int idade1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade do segundo aluno: ");
            int idade2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade do terceiro aluno: ");
            int idade3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade do quarto aluno: ");
            int idade4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade do quinto aluno: ");
            int idade5 = Convert.ToInt32(Console.ReadLine());

            int media = ((idade1 + idade2 + idade3 + idade4 + idade5) / 5);
            Console.WriteLine("A média de idade dos 5 alunos é igual a: " + media);

        }
    }
}