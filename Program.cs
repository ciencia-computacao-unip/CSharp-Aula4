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

            Console.ReadKey();
        }
    }
}
