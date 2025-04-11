//Tarefa JurosSimples
Console.Clear();

decimal c, j, m;
double i;
int t;
Console.Write("Insira seu Capital:(R$)");
c = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("Insira os Juros: ");
i = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Adicione os Meses: ");
t = Convert.ToInt32(Console.ReadLine()!);

j = c * Convert.ToDecimal(i / 100) * t;
m = c + j;
Console.Write("Seus juros são de: ");
    Console.WriteLine($"{j}");
Console.Write("Seu montante é de: ");
    Console.Write($"{m}");