double temperatura = 0;
double conversao = 0;
string opcao = "C";

Console.WriteLine("Qual o valor da TEMPERATURA que deseja converter?");
temperatura = double.Parse(Console.ReadLine());

Console.WriteLine("Deseja converter para qual UNIDADE DE TEMPERATURA?");
Console.WriteLine("C - Graus CELSIUS");
Console.WriteLine("F - Graus FAHRENHEIT");
opcao = Console.ReadLine();

Console.WriteLine("");

switch (opcao)
{
    case "C":
        // (0 °C x 9/5) + 32 = 32 °F
        conversao = (temperatura * 9 / 5) + 32;
        break;

    case "F":
        // (0 °F -32) x 5/9 = -17,78 °C
        conversao = (temperatura - 32) * 9 / 5;
        break;

    default:

        break;
}

Console.WriteLine("Temperatura convertida é: " + conversao);