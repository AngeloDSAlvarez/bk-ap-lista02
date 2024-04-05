
int[] vetor1 = {2, 3, 4};
int[] vetor2 = {2, 3, 4};
int[] vetorResultado = {0, 0, 0};



for (int i = 0; i < vetor1.Length; i++)
{
    vetorResultado[i] = vetor1[i] + vetor2[i];
}


foreach (int i in vetorResultado)
{
    Console.WriteLine(i);
}

