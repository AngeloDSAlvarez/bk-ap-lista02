
int[] numeros = { 4, 2, 12, 4, 10 };

int maiorNumero = numeros[0];
int menorNumero = numeros[0];
foreach (int numero in numeros)
{  
    if (numero > maiorNumero)
    {
        maiorNumero = numero;
    }

    if (numero < menorNumero)
    {
        menorNumero = numero;
    }
}

Console.WriteLine("Maior numero: " + maiorNumero + "\nMenor numero: " +  menorNumero);    