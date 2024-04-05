// Matriz de animais [Nome, Espécie, Idade, Peso]
string[,] animais = {
{ "Fido", "Cachorro", "5", "10kg" },
{ "Whiskers", "Gato", "5", "5kg" },
{ "Buddy", "Cachorro", "3", "8kg" },
{ "Fluffy", "Gato", "2", "4kg" },
{ "Spot", "Cachorro", "4", "12kg" }
};

//Pergunta a opção de busca do animal
Console.WriteLine("Como voce quer busca o animal? \n" +
    "1 - nome\n" +
    "2 - especie\n" +
    "3 - idade\n" +
    "4 - peso\n");

//armazena a opção de busca
int opcaoBusca = Convert.ToInt16(Console.ReadLine());

//pede a busca em si, como o nome do cachorro, ou a especie
Console.WriteLine("Digite a busca: ");
string busca = Console.ReadLine();

//variavel para contar quando animais foram achados na busca
int animaisAchados = 0;

//switch para verificar como quer buscar o animal
switch (opcaoBusca)
{
    case 1:
        Console.Clear();
        //for para percorrer a matriz, enquanto i for menor que animais.length/4, por que possui 4 colunas
        for (int i = 0; i < (animais.Length / 4 ); i++)
        {
            //se a busca for igual a algum animal da lista, na posição que escolheu procurar
            if (animais[i, 0] == busca)
            {
                Console.WriteLine("Achei o seu animal!\n ");
                Console.WriteLine("Nome: " + animais[i, 0] + "\n" +
                    "Especie: " + animais[i, 1] + "\n" +
                    "Idade: " + animais[i, 2] + " anos\n" +
                    "Peso: " + animais[i, 3] + "\n\n");
                animaisAchados++;
            } 
            //caso não tenha o animal
            else if (i == (animais.Length / 4) - 1 && animaisAchados == 0)
            {
                Console.WriteLine("Lamento, nao achamos seu animal! :(");
            }
        }
        break;


    case 2:
        Console.Clear();
        //for para percorrer a matriz, enquanto i for menor que animais.length/4, por que possui 4 colunas
        for (int i = 0; i < (animais.Length / 4); i++)
        {
            //se a busca for igual a algum animal da lista, na posição que escolheu procurar
            if (animais[i, 1] == busca)
            {
                Console.WriteLine("Achei o seu animal!\n ");
                Console.WriteLine("Nome: " + animais[i, 0] + "\n" +
                    "Especie: " + animais[i, 1] + "\n" +
                    "Idade: " + animais[i, 2] + " anos\n" +
                    "Peso: " + animais[i, 3] + "\n\n");
                animaisAchados++;
            }
            //caso não tenha o animal
            else if (i == (animais.Length / 4) - 1 && animaisAchados == 0)
            {
                Console.WriteLine("Lamento, nao achamos seu animal! :(");
            }
        }
        break;

    case 3:
        Console.Clear();
        //for para percorrer a matriz, enquanto i for menor que animais.length/4, por que possui 4 colunas
        for (int i = 0; i < (animais.Length / 4); i++)
        {
            //se a busca for igual a algum animal da lista, na posição que escolheu procurar
            if (animais[i, 2] == busca )
            {
                Console.WriteLine("Achei o seu animal!\n ");
                Console.WriteLine("Nome: " + animais[i, 0] + "\n" +
                    "Especie: " + animais[i, 1] + "\n" +
                    "Idade: " + animais[i, 2] + " anos\n" +
                    "Peso: " + animais[i, 3] + "\n\n");
                animaisAchados++;
            }
            //caso não tenha o animal
            else if (i == (animais.Length / 4) - 1 && animaisAchados == 0)
            {
                Console.WriteLine("Lamento, nao achamos seu animal! :(");
            }
        }
        break;

    case 4:
        Console.Clear();
        //for para percorrer a matriz, enquanto i for menor que animais.length/4, por que possui 4 colunas
        for (int i = 0; i < (animais.Length / 4); i++)
        {
            //se a busca for igual a algum animal da lista, na posição que escolheu procurar
            if (animais[i, 3] == busca)
            {
                Console.WriteLine("Achei o seu animal!\n ");
                Console.WriteLine("Nome: " + animais[i, 0] + "\n" +
                    "Especie: " + animais[i, 1] + "\n" +
                    "Idade: " + animais[i, 2] + " anos\n" +
                    "Peso: " + animais[i, 3] + "\n\n");
                animaisAchados++;
            }
            //caso não tenha o animal
            else if (i == (animais.Length / 4) - 1 && animaisAchados == 0)
            {
                Console.WriteLine("Lamento, nao achamos seu animal! :(");
            }
        }
        break;

    default:
        Console.WriteLine("Digite uma opcao valida! ");
        break;
}