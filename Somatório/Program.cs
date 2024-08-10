Console.Write("Digite um número: ");
int N = Convert.ToInt32(Console.ReadLine());
int soma = 0;

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        soma += i;
    }
}
else
{
    for (int i = N; i <= 1; i++)
    {
        soma += i;
    }

}
Console.WriteLine($"A soma de 1 a {N} é: {soma}");
Console.ReadKey();