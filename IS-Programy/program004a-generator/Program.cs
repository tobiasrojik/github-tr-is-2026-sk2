
// jako prvni si pripravime smycku pro opakovani programu

string again = "a";
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("******** Generátor pseudonáhodných čísel *******");
    Console.WriteLine("************************************************");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Tobiáš Rojík ******************");
    Console.WriteLine("************************************************");

    // Zadání počtu čísel
    Console.Write("Zadejte počet čísel: ");
    int pocet;
    while(!int.TryParse(Console.ReadLine(), out pocet) || pocet <= 0)
    {
        Console.Write("Zadejte kladný počet čísel: ");
    }

    // Zadání dolní meze
    Console.Write("Zadejte dolní mez: ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Zadejte celé číslo: ");
    }

    // Zadání horní meze
    Console.Write("Zadejte horní mez: ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Horní mez musí být větší nebo rovna dolní mezi. Zadejte znovu: ");
    }

    // Vytvoření generátoru náhodných čísel
    Random nahoda = new Random();

    // Vytvoření pole
    int[] cisla = new int[pocet];

    // Generování čísel
    for(int i = 0; i < pocet; i++)
    {
        cisla[i] = nahoda.Next(lowerBound, upperBound + 1);
    }

    // Výpis čísel
    Console.WriteLine();
    Console.WriteLine("Vygenerovaná čísla:");

    for(int i = 0; i < pocet; i++)
    {
        Console.WriteLine(cisla[i]);
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakovani stisknete klavesu Enter");
    Console.WriteLine("Jakoukoliv jinou ukoncite");
    Console.WriteLine();
    Console.Write("Chcete spustit znovu? : ");
    again = Console.ReadLine() ?? "";
}
