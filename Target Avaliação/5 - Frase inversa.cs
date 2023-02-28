using System;

class Program {
    static void Main(string[] args) {
        string original = "exemplo de string";
        string invertido = "";

        for (int i = original.Length - 1; i >= 0; i--) {
            invertido += original[i];
        }

        Console.WriteLine("String original: " + original);
        Console.WriteLine("String invertida: " + invertido);
    }
}