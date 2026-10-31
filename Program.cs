Console.WriteLine("A lista ordenada deve iniciar com o número:");
int inicio = int.Parse(Console.ReadLine());

Console.WriteLine("até o número:");
int fim = int.Parse(Console.ReadLine());

int[] array = CriaArray(inicio, fim);

Console.WriteLine("\nDigite o número a ser buscado:");
int alvo = int.Parse(Console.ReadLine());

int chute = (array.Length - 1) / 2;
for (var i = 0; i <= array.Length - 1; i++)
{        
    if (array[chute] == alvo)
    {
        Console.WriteLine($"\nNúmero {array[chute]} encontrado após {i} tentativas.");
        break;
    }

    if (array[chute] < alvo)
    {
        Array.Copy(array, chute + 1, array, 0, (array.Length - 1) - chute);
        LimpaArray(chute, array.Length - 1, array);
        exibeArrayNaTela(array);
        chute = chute / 2;
    }
    else
    {
        Array.Copy(array, 0, array, 0, chute - 1);
        LimpaArray(chute, array.Length - 1, array);
        exibeArrayNaTela(array);
        chute = chute / 2;
    }
}

static int[] CriaArray(int inicio, int fim)
{
    int[] array = new int[fim - inicio + 1];
    for (var i = inicio; i <= fim; i++)
    {
        array[i - inicio] = i;
    }

    exibeArrayNaTela(array);
    return array;
}

static void exibeArrayNaTela(int[] array)
{
    int numeroDeElementos = array.Length;    
    Console.WriteLine($"\nLista Ordenada:\n [{string.Join(", ", array)}]");
}

static int[] LimpaArray(int inicio, int fim, int[] array)
{    
    for (var i = inicio; i <= fim; i++)
    {
        array[i] = 0;
    }
    
    return array;
}