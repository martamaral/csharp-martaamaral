Console.WriteLine("Essa aplicação calcula a subtração de dois números.");
Console.WriteLine("Digite o primeiro número: ");

bool conversao = double.TryParse(Console.ReadLine(), out double numero1);

while (!conversao)
{
    Console.WriteLine("Número inválido. Digite novamente");
    conversao = double.TryParse(Console.ReadLine(), out numero1);
}

Console.WriteLine("Digite o segundo número: ");

conversao = double.TryParse(Console.ReadLine(), out double numero2);

while (!conversao)
{
    Console.WriteLine("Número inválido. Digite novamente");
    conversao = double.TryParse(Console.ReadLine(), out numero2);
}

double subtracao = numero1 - numero2;

Console.WriteLine($"O resultado da subtração dos números {numero1} e {numero2} é {subtracao}");
