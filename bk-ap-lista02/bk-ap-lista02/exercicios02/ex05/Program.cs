//função para achar maior numero em uma matriz 4x4
int achaMaiorNumero(int[,] maiorNumero) {
    //inicializa variavel numeroMaior com a primeira posição da matriz
    int numeroMaior = maiorNumero[0, 0];

    //loops para acessarem toda a matriz
    for (int i = 0; i < maiorNumero.Length / 4; i++)
    {
        for (int j = 0; j < maiorNumero.Length / 4; j++)
        {  
            //verifica se o numeroMaior é maior que o numero atual da matriz
            if (numeroMaior > maiorNumero[i, j])
            {
                //se for, atualiza o numeroMaior
                numeroMaior = maiorNumero[i, j];
            }
        }
    }
    //retorna o numeroMaior
    return numeroMaior;
}

//cria e inicializa matriz 4x4
int[,] numAleatorio =
{
    {0,0,0,0},
    {0,0,0,0},
    {0,0,0,0},
    {0,0,0,0}
};

//instacia classe para numeros aleatórios
Random aleatorio = new Random();

//loops para acessarem toda a matriz
for (int i = 0; i < numAleatorio.Length / 4; i++)
{
    for (int j = 0; j < numAleatorio.Length / 4; j++)
    {
        //define um numero aleatorio para a matriz
        numAleatorio[i, j] = aleatorio.Next();
    }
}

//chama a função para achar o maior numero da matriz
int maiorNumero = achaMaiorNumero(numAleatorio);


Console.WriteLine("Maior numero na matriz: " + maiorNumero);