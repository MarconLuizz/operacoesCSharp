using System;

namespace Calculadora
{
  class Program
  {
    static void Main(string[] args)
    {
      // Leitura e validação do primeiro número
      Console.Write("Digite o primeiro número: ");
      if (!int.TryParse(Console.ReadLine(), out int num1))
      {
        Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        return;
      }

      // Leitura e validação do segundo número
      Console.Write("Digite o segundo número: ");
      if (!int.TryParse(Console.ReadLine(), out int num2))
      {
        Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        return;
      }

      // Escolha da operação
      Console.Write("Escolha uma opção: 1 - Soma | 2 - Subtração | 3 - Multiplicação | 4 - Divisão: ");
      if (!int.TryParse(Console.ReadLine(), out int calcTipo))
      {
        Console.WriteLine("Opção inválida. Escolha entre 1, 2, 3 ou 4.");
        return;
      }

      // Executa a operação escolhida
      int resultado = 0;
      switch (calcTipo)
      {
        case 1:
          resultado = Somar(num1, num2);
          break;
        case 2:
          resultado = Subtrair(num1, num2);
          break;
        case 3:
          resultado = Multiplicacao(num1, num2);
          break;
        case 4:
          if (num2 == 0)
          {
            Console.WriteLine("Erro: divisão por zero não é permitida.");
            return;
          }
          resultado = Divisao(num1, num2);
          break;
        default:
          Console.WriteLine("Opção inválida. Use 1, 2, 3 ou 4.");
          return;
      }

      // Exibe o resultado
      Console.WriteLine($"\nO resultado da operação {calcTipo} com os valores {num1} e {num2} é: {resultado}");
      Console.WriteLine("Pressione qualquer tecla para sair.");
      Console.ReadKey();
    }

    // Métodos de operação
    static int Somar(int a, int b) => a + b;
    static int Subtrair(int a, int b) => a - b;
    static int Multiplicacao(int a, int b) => a * b;
    static int Divisao(int a, int b) => a / b;
  }
}
