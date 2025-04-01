//Tarefa JurosSimple
Console.Clear();

double c, j, i, t, m;
Console.Write("Capital: ");
c = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Juros: ");
i = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Meses: ");
t = Convert.ToDouble(Console.ReadLine()!);

j = c * i * t / 100;
m = c + j;
Console.Write("Seus juros são de: ");
    Console.WriteLine($"{j}");
Console.Write("Seu montante é de: ");
    Console.Write($"{m}");