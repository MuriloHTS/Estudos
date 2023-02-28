using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite um número inteiro: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 0;
        int i = 2;

        while (c < n) {
            c = a + b;
            a = b;
            b = c;
            i++;
        }

        if (c == n) {
            Console.WriteLine("{0} faz parte da sequência de Fibonacci e está na posição {1}.", n, i);
        } else {
            Console.WriteLine("{0} não faz parte da sequência de Fibonacci.", n);
        }
    }
}
