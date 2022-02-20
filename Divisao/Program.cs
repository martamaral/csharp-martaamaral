Console.WriteLine("Essa aplicação calcula a divisão entre dois números.");
Console.WriteLine("Digite o primeiro número: ");

bool conversao = double.TryParse(Console.ReadLine(), out double numero1);

while (!conversao)
{
    Console.WriteLine("Número inválido. Digite novamente");
    conversao = double.TryParse(Console.ReadLine(), out numero1);
}

Console.WriteLine("Digite o segundo número: ");

conversao = double.TryParse(Console.ReadLine(), out double numero2);

while (!conversao || numero2 == 0)
{
    Console.WriteLine("Número inválido. Digite novamente");
    conversao = double.TryParse(Console.ReadLine(), out numero2);
}

double divisao = numero1 / numero2;

Console.WriteLine($"O resultado da divisão entre os números {numero1} e {numero2} é {divisao:F2}");


