using System;

namespace Calculator
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual a operação desejada?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Calcular área");
            Console.WriteLine("6 - Sair do programa");
            
            Console.WriteLine("----------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Sub(); break;
                case 3: Div(); break;
                case 4: Multi(); break;
                case 5: MenuArea(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            //Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            //Console.WriteLine($"O resultado da soma é: {v1+v2}");
            //Console.WriteLine("O resultado da soma é: " + (v1+v2));
            Console.ReadKey();
            Menu();
        }
        static void Sub()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            //Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            //Console.WriteLine($"O resultado da soma é: {v1+v2}");
            //Console.WriteLine("O resultado da soma é: " + (v1+v2));   
            Console.ReadKey(); 
            Menu();
        }
        static void Div()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            //Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            //Console.WriteLine($"O resultado da soma é: {v1+v2}");
            //Console.WriteLine("O resultado da soma é: " + (v1+v2));
            Console.ReadKey();
            Menu();
        }
        static void Multi()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            //Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            //Console.WriteLine($"O resultado da soma é: {v1+v2}");
            //Console.WriteLine("O resultado da soma é: " + (v1+v2));
            Console.ReadKey();
            Menu();
        }

        static void MenuArea()
        {
            Console.Clear();
            Console.WriteLine("Deseja calcular a área de qual forma geométrica?");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Retângulo");
            Console.WriteLine("3 - Círculo");
            Console.WriteLine("4 - Triângulo");
            Console.WriteLine("5 - Paralelogramo");
            Console.WriteLine("6 - Trapézio");
            Console.WriteLine("7 - Voltar");
            
            Console.WriteLine("----------------");
            Console.WriteLine("Selecione a forma desejada: ");
            short res2 = short.Parse(Console.ReadLine());

            switch (res2)
            {
                case 1: Quad(); break;
                case 2: Ret(); break;
                case 3: Circ(); break;
                case 4: Tri(); break;
                case 5: Los(); break;
                case 6: Trap(); break;
                case 7: Menu(); break;
                default: System.Environment.Exit(0); break;
            }
        }

        static void Quad()
        {
            Console.Clear();
            Console.WriteLine("Digite o comprimento de um lado: ");
            float Quad1 = float.Parse(Console.ReadLine());

            float AQuad = Quad1 * Quad1;
            Console.WriteLine($"A área do quadrado possui {AQuad}m²");
            Console.ReadKey(); 
            MenuArea();
        }

        static void Ret()
        {
            Console.Clear();
            Console.WriteLine("Digite o comprimento da base: ");
            float baseRet = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a altura: ");
            float altRet = float.Parse(Console.ReadLine());

            float ARet = baseRet * altRet;
            Console.WriteLine($"A área do retângulo possui {ARet}m2");
            Console.ReadKey(); 
            MenuArea();
        }

        static void Circ()
        {
            Console.Clear();
            Console.WriteLine("π foi arredondado para 3,14");
            Console.WriteLine("Digite o comprimento do raio: ");
            float raioCirc = float.Parse(Console.ReadLine());

            double ACirc = 3.14 * (raioCirc * raioCirc);
            Console.WriteLine($"A área do círculo é {ACirc}m²");
            Console.ReadKey(); 
            MenuArea();
        }

        static void Tri()
        {
            Console.Clear();
            Console.WriteLine("Digite o comprimento da base: ");
            float baseTri = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a altura: ");
            float altTri = float.Parse(Console.ReadLine());

            float ATri = (baseTri * altTri) / 2;
            Console.WriteLine($"A área do triângulo possui {ATri}m²");
            Console.ReadKey(); 
            MenuArea();
        }

        static void Los()
        {
            Console.Clear();
            Console.WriteLine("Digite a medida da diagonal maior: ");
            float DiagLos = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a medida da diagonal menor: ");
            float diagLos = float.Parse(Console.ReadLine());

            float ALos = (DiagLos * diagLos) / 2;
            Console.WriteLine($"A área do losango possui {ALos}m²");
            Console.ReadKey(); 
            MenuArea();
        }

        static void Trap()
        {
            Console.Clear();
            Console.WriteLine("Digite o comprimento da base maior: ");
            float BaseTrap = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o comprimento da base menor: ");
            float baseTrap = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            float altTrap = float.Parse(Console.ReadLine());

            float ATrap = ((BaseTrap + baseTrap) * altTrap) / 2;
            Console.WriteLine($"A área do trapézio possui {ATrap}m²");
            Console.ReadKey(); 
            MenuArea();
        }
    }
}