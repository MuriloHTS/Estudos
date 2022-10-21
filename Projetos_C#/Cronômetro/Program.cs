menu();

static void menu()
{
    Console.Clear();
    Console.WriteLine("Deseja a contagem em minutos ou em segundos?");
    Console.WriteLine("1 - Minutos");
    Console.WriteLine("2 - Segundos");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("Escolha uma opção: ");

    int escolha = int.Parse(Console.ReadLine());
    
    switch(escolha)
    {
        case 1: StartM(); break; 
        case 2: StartS(); break;
        default: System.Environment.Exit(0); break;
    }
}

static void StartM()
{
    int currentTime = 0;

    Console.WriteLine("Digite o tempo desejado em minutos: ");
    int time = int.Parse(Console.ReadLine());

    while(currentTime != time * 60)
    {
        Console.Clear();
        currentTime++; 
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.WriteLine("Cronômetro finalizado!");
    Thread.Sleep(2000);
    menu();
}

static void StartS()
{
    int currentTime = 0;

    Console.WriteLine("Digite o tempo desejado em segundos: ");
    int time = int.Parse(Console.ReadLine());

    while(currentTime != time)
    {
        Console.Clear();
        currentTime++; 
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.WriteLine("Cronômetro finalizado!");
    Thread.Sleep(2000);
    menu();
}