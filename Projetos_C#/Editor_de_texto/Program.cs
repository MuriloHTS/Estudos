Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir um arquivo");
    Console.WriteLine("2 - Criar um novo arquivo");
    Console.WriteLine("0 - Sair");
    short escolha = short.Parse(Console.ReadLine());

    switch(escolha){
        case 1: Abrir(); break;
        case 2: Criar(); break;
        case 0: Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual o caminho do arquivo?");
    string path = Console.ReadLine();

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }
}

static void Criar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
    Console.WriteLine("--------------------------");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }while (Console.ReadKey().Key != ConsoleKey.Escape);
    
    Console.Write(text);

    Salvar(text);
}

static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine("Qual o caminho para salvar o arquivo?");
    var path = Console.ReadLine();

    using(var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"O arquivo {path} foi salvo com sucesso!");
    Console.ReadLine();
    Menu();
}