// Exercício curso Nélio Alves em .NET
// Nesse programa faremos com que o usuario digite numeros inteiros ate que seja que esse numero seja negativo.
// Assim que for negativo o programa se encerra, trazendo a media de todos os positivos digitados!!

int cont;
double soma, media;

Console.WriteLine("Digite uma idade: ");
double Num = double.Parse(Console.ReadLine());

soma = 0.0;
cont = 0;

while (Num >= 0)
{
    soma = soma + Num;
    cont = cont + 1;
    Console.WriteLine("Digite outra idade: ");
    Num = int.Parse(Console.ReadLine());
}
if (cont == 0)
{
    Console.WriteLine("Impossivel calcular!");
}
else
{
    media = soma / cont;
    Console.WriteLine("A média das idades é: " + media.ToString("F1") + " anos!");
}


