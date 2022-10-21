Start();

static void Start()
{
    string tempinho = Console.ReadLine();
    int tempao = int.Parse(tempinho.Substring(tempinho.Length - 6, 2));

    Console.Clear();

    Console.WriteLine("Digite o tempo separado por ':' - ");

    Console.WriteLine($"{tempao}");
}
