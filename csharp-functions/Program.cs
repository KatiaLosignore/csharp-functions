// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// UTILIZZO DELLE FUNZIONI

// dichiaro l'array nel codice

int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

// stampo l’array di numeri creato

StampaArray(arrayNumeri);

Console.WriteLine("----------------------------------");

// stampo l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato

StampaArray(ElevaArrayAlQuadrato(arrayNumeri));

// verifico che l’array originale non sia stato modificato quindi ristampo nuovamente l’array originale e verifico che sia rimasto [2, 6, 7, 5, 3, 9])

StampaArray(arrayNumeri);

Console.WriteLine("----------------------------------");

// Stampo la somma di tutti i numeri

Console.WriteLine($"La somma di tutti i numeri contenuti all'interno dell'array è di {SommaElementiArray(arrayNumeri)}");

Console.WriteLine("----------------------------------");

// Stampo la somma di tutti i numeri elevati al quadrati

Console.WriteLine($"La somma di tutti i numeri contenuti all'interno dell'array elevati al quadrato è di {SommaElementiArray(ElevaArrayAlQuadrato(arrayNumeri))}");



// FUNZIONI 

// funzione che che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.

void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }

    Console.WriteLine("]");

}

// funzione che restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero)
{
    return (numero * numero);
}

// funzione che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati al quadrato.
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();

    for(int i = 0; i < arrayCopy.Length; i++)
    {
        arrayCopy[i] = Quadrato(arrayCopy[i]);
    }

    return arrayCopy;
}

// funzione che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int SommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++) 
    {
        somma+= array[i];
    }

    return somma;
}

