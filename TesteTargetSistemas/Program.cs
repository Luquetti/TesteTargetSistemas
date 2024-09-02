//1 :
using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceAFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceAFibonacci(int numero)
    {
        if (numero < 0)
        {
            return false;
        }

        int a = 0;
        int b = 1;

        while (a <= numero)
        {
            if (a == numero)
            {
                return true;
            }

            int proximo = a + b;
            a = b;
            b = proximo;
        }

        return false;
    }
}

//2:


class Program2
{
    static void Main(string[] args)
    {
      
        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();
        int count = 0;

        foreach (char c in input)
        {
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' ocorre {count} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada na string.");
        }
    }
}
//3: soma =77;

//4) Descubra a lógica e complete o próximo elemento:
//a) 1, 3, 5, 7, 9
//b) 2, 4, 8, 16, 32, 64, 128
//c) 0, 1, 4, 9, 16, 25, 36, 49
//d) 4, 16, 36, 64, 100
//e) 1, 1, 2, 3, 5, 8,13
//f) 2,10, 12, 16, 17, 18, 19,21
//5 Primeiro, iria ligar uma das lâmpadas,e verificar qual delas caso fosse incandescente estivesse mais quente ao chegar proximo,a baseado nisso deixaria a outra para deixa acesa e conferir qual delas seria ou não a lampada acesa.
