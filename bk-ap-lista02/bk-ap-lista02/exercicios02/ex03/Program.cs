
int[,] numeros =
{
    {0, 0, 0},
    {0, 0, 0},
    {0, 0, 0}
};

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        numeros[i, j] = Convert.ToInt16(Console.ReadLine());
    }
}

Console.Clear();
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
