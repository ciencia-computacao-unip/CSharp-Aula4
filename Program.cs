using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Aula4{
    class Program{
        static void Main(string[] args){

            //início exercício 1
            Console.WriteLine("1) Escreva um programa que exiba o seguinte menu para o usuário e realize seus respectivos cálculo. Utilizar dois valores de entrada para cada operação.\n1 – Adição\n2 – Subtração\n3 – Multiplicação\n4 – Divisão\n");
            decimal primeiro_numero = 0, segundo_numero = 0, resultado = 0;
            int escolha = 0;
            bool erro = false;
            Console.Write("Digite o primeiro número: ");
            primeiro_numero = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            segundo_numero = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Escolha uma das opções:\n   1 – Adição\n   2 – Subtração\n   3 – Multiplicação\n   4 – Divisão");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    resultado = primeiro_numero + segundo_numero;
                    break;

                case 2:
                    resultado = primeiro_numero - segundo_numero;
                    break;

                case 3:
                    resultado = primeiro_numero * segundo_numero;
                    break;

                case 4:
                    resultado = primeiro_numero / segundo_numero;
                    break;

                default:
                    erro = true;
                    Console.WriteLine("Erro: digite um número de 1 a 4");
                    break;
            }
            if (erro == false)
            {
                Console.WriteLine("O resultado é {0}", resultado);
            }
            //fim exercício 1

            Console.WriteLine("\n\n\n");

            //início exercício 2
            Console.WriteLine("Escreva um programa que exiba o seguinte menu para o usuário e realize o que se pede.\n1 – Calcular a média de 2 notas\n2 – Calcular a média de 3 notas\n3 – Calcular a média de 4 notas\n");
            Console.Write("Quantidade de notas a calcular: ");
            int quantidade_notas;

            quantidade_notas = int.Parse(Console.ReadLine());
            decimal[] notas = new decimal[quantidade_notas];
            decimal nota_final = 0;
            for (int i = 1; i <= quantidade_notas; i++)
            {
                Console.Write("Nota {0}:", i);
                notas[i - 1] = decimal.Parse(Console.ReadLine());
                nota_final = nota_final + notas[i - 1];
            }
            nota_final = nota_final / quantidade_notas;
            Console.WriteLine("\nA média é: {0}", nota_final);
            //fim exercício 2

            Console.ReadKey();
        }
    }
}
