
Console.WriteLine("!");

// Smycka pro opakovani programu
string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();

    Console.WriteLine("************************************************");
    Console.WriteLine("******** Generátor pseudonáhodných čísel ********");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Tobiáš Rojík ******************");
    Console.WriteLine("************************************************");

    // Zadani poctu cisel
    Console.Write("Zadejte pocet cisel: ");
    int pocet;
    while (!int.TryParse(Console.ReadLine(), out pocet) || pocet <= 0)
    {
        Console.Write("Zadejte kladny pocet cisel: ");
    }

    // Zadani dolni meze
    Console.Write("Zadejte dolni mez: ");
    int dolni;
    while (!int.TryParse(Console.ReadLine(), out dolni))
    {
        Console.Write("Zadejte cele cislo: ");
    }

    // Zadani horni meze
    Console.Write("Zadejte horni mez: ");
    int horni;
    while (!int.TryParse(Console.ReadLine(), out horni) || horni <= dolni)
    {
        Console.Write("Horni mez musi byt vetsi nez dolni mez: ");
    }

    // Vytvoreni generatoru nahodnych cisel
    Random nahoda = new Random();

    // Vytvoreni pole
    int[] cisla = new int[pocet];

    // Pocitadla
    int kladna = 0;
    int zaporna = 0;
    int nulova = 0;
    int suda = 0;
    int licha = 0;

    // Generovani cisel
    for (int i = 0; i < pocet; i++)
    {
        cisla[i] = nahoda.Next(dolni, horni + 1);
    }

    Console.WriteLine();
    Console.WriteLine("Vygenerovana cisla:");
    Console.WriteLine();

    // Vypis cisel a jejich kontrola
    for (int i = 0; i < pocet; i++)
    {
        Console.Write(cisla[i] + " ");

        // Kladna, zaporna a nulova cisla
        if (cisla[i] > 0)
        {
            kladna++;
        }
        else if (cisla[i] < 0)
        {
            zaporna++;
        }
        else
        {
            nulova++;
        }

        // Suda a licha cisla
        if (cisla[i] % 2 == 0)
        {
            suda++;
        }
        else
        {
            licha++;
        }
    }

    // Vypis vysledku
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("*************** Vysledky ****************");

    Console.WriteLine("Kladna cisla: " + kladna);
    Console.WriteLine("Zaporna cisla: " + zaporna);
    Console.WriteLine("Nulova cisla: " + nulova);

    Console.WriteLine("Suda cisla: " + suda);
    Console.WriteLine("Licha cisla: " + licha);

    Console.WriteLine("******************************************");

    // Opakovani programu
    Console.WriteLine();
    Console.WriteLine("Pro opakovani stisknete klavesu a");
    Console.WriteLine("Jakoukoliv jinou klavesou ukoncite");
    Console.Write("Chcete spustit znovu? : ");

    again = Console.ReadLine() ?? "";
}
