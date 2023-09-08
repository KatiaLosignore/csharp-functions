// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// UTILIZZO DELLE FUNZIONI

// dichiaro l'array nel codice

int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

// stampo l’array di numeri creato

StampaArray(arrayNumeri);

Console.WriteLine("----------------------------------");

// stampo l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato

int[] arrayAlQuadrato = ElevaArrayAlQuadrato(arrayNumeri);

StampaArray(arrayAlQuadrato);

// verifico che l’array originale non sia stato modificato quindi ristampo nuovamente l’array originale e verifico che sia rimasto [2, 6, 7, 5, 3, 9])

StampaArray(arrayNumeri);

Console.WriteLine("----------------------------------");

// Stampo la somma di tutti i numeri

Console.WriteLine($"La somma di tutti i numeri contenuti all'interno dell'array è di {SommaElementiArray(arrayNumeri)}");

Console.WriteLine("----------------------------------");

// Stampo la somma di tutti i numeri elevati al quadrati

Console.WriteLine($"La somma di tutti i numeri contenuti all'interno dell'array elevati al quadrato è di {SommaElementiArray(arrayAlQuadrato)}");

Console.WriteLine("----------------------------------");

/* BONUS 
Modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. */


// Inserito controllo per l'inserimento del numero scelto dall'utente

int numeroElementi = 0;

Console.WriteLine("Indica quanti numeri vuoi inserire all'interno dell'array: ");

while (int.TryParse(Console.ReadLine(), out numeroElementi) == false)
{
    Console.WriteLine($"Attenzione, non hai inserito un numero corretto! Riprova: ");
}

Console.WriteLine($"Hai scelto che l'array verrà composto da {numeroElementi} elementi");

// creo l'array con le dimensioni scelte dall'utente
int[] arrayUtente = new int[numeroElementi];

for (int i = 0; i < arrayUtente.Length; i++)
{
    Console.Write($"Inserisci il {i + 1}° numero: ");
    arrayUtente[i] = int.Parse(Console.ReadLine());
}

Console.Write($"L'array da te scelto è il seguente: ");

StampaArray(arrayUtente);

Console.WriteLine("----------------------------------");

/* BONUS EXTRA
Definire due funzioni ricorsive:

1) Una funzione che, dato un numero intero n > 0, ne calcoli il fattoriale
2) Una funzione che, dato un numero intero n >= 0, restituisca l'n-esimo elemento della sequenza di Fibonacci.

*/


 Console.Write("Inserisci un numero intero positivo per calcolare il fattoriale: ");
 int numeroFattoriale = int.Parse(Console.ReadLine());

 int risultatoFattoriale = CalcolaFattoriale(numeroFattoriale);

 Console.WriteLine($"Il fattoriale di {numeroFattoriale} è {risultatoFattoriale}");

 Console.Write("Inserisci un numero intero non negativo per ottenere l'n-esimo elemento di Fibonacci: ");
        
 int numeroFibonacci = int.Parse(Console.ReadLine());

 int risultatoFibonacci = CalcolaFibonacci(numeroFibonacci);

 Console.WriteLine($"L'n-esimo elemento di Fibonacci è {risultatoFibonacci}");

 static int CalcolaFattoriale(int n)
 {
    if (n <= 0)
        return 1;
    return n * CalcolaFattoriale(n - 1);   // 3 * 2 * 1
 }
static int CalcolaFibonacci(int n)
{
    if (n < 2)
        return n;
    return CalcolaFibonacci(n - 1) + CalcolaFibonacci(n - 2);
}




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

