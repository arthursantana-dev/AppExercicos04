using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio04
{
    internal class Program
    {
        static void ExemploSwitch()
        {
            int teste = int.Parse(Console.ReadLine());

            switch (teste)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                default:
                    Console.WriteLine("Opção Inválida.");

                    break;

            }

        }

        static void SwitchFigura()
        {
            Console.WriteLine("Qual figura você quer calcular a área?\n1.Quadrado\n2.Retângulo\n3.Trapézio\n4.Losango");
            int opcaoFigura = int.Parse(Console.ReadLine());

            float medidaA = 0;
            float medidaB = 0;
            float medidaC = 0;

            switch (opcaoFigura)
            {
                case 1:
                    Console.WriteLine("Insira a medida do lado do quadrado:");
                    medidaA = float.Parse(Console.ReadLine());
                    break;

                case 4: 
                    Console.WriteLine("Insira a medida das diagonais:");
                    medidaA = float.Parse(Console.ReadLine());
                    medidaB = float.Parse(Console.ReadLine());
                    break;

                case 3:
                    Console.WriteLine("Insira a medida dos lados e da altura:");
                    medidaA = float.Parse(Console.ReadLine());
                    medidaB = float.Parse(Console.ReadLine());
                    medidaC = float.Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Insira a medida dos lados:");
                    medidaA = float.Parse(Console.ReadLine());
                    medidaB = float.Parse(Console.ReadLine());
                    break;
            }

            switch(opcaoFigura)
            {
                case 1:
                    Console.WriteLine($"A área do quadrado é dada por {Math.Pow(medidaA, 2)} (L^2)");
                    break;

                case 2:
                    Console.WriteLine($"A área do retângulo é dada por {medidaA * medidaB} (L*h)");
                    break;

                case 3:
                    Console.WriteLine($"A área do trapézio é dada por {(medidaA + medidaB) * medidaC / 2} ((B+b)h/2)");
                    break;
                case 4:
                    Console.WriteLine($"A área do losango é dada por {medidaA*medidaB/2} (D*d/2)");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                break;
            }

            Console.WriteLine("\n");
        }

        static void ContaBancaria()
        {
            Console.WriteLine("Insira seu saldo (R$):");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite:\n    D para depósito;\n    S para saque;");
            string operacao = Console.ReadLine();
            operacao = operacao.ToUpper();

            switch (operacao)
            {
                case "D":
                    Console.WriteLine("Insira o valor de depósito (R$): ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    saldo += valorDeposito;
                    Console.WriteLine($"Seu saldo agora é de R${saldo}");
                    break;

                case "S":
                    Console.WriteLine("Insira o valor a ser sacado (R$): ");
                    double valorSacado = double.Parse(Console.ReadLine());
                    while (valorSacado > saldo)
                    {
                        Console.WriteLine("Sua requisição de saque é maior que o saldo!\nInsira outro valor (R$): ");
                        valorSacado = double.Parse (Console.ReadLine());
                    }
                    saldo -= valorSacado;
                    Console.WriteLine($"Seu saldo agora é de R${saldo}");
                    break;

                default:
                    Console.WriteLine("Ocorreu um erro");
                    break;
            }
        }
        static void Main(string[] args)
        {
            //ExemploSwitch();
            //SwitchFigura();
            ContaBancaria();
            Console.ReadKey();
        }
    }
}

