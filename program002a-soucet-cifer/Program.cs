
string again = "a";
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("************* Soucet a soucin cifer ************");
    Console.WriteLine("************************************************");

    Console.WriteLine("Zadejte cele cislo:");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste cele cislo, zadejte znovu: ");
    }

    // promenne pro soucet a soucin
    int soucet = 0;
    int soucin = 1;

    // promenne pro vypis cifer
    string vypisScitani = "";
    string vypisNasobeni = "";

    // osetreni zaporneho cisla
    number = Math.Abs(number);

    if (number == 0)
    {
        soucin = 0;
        vypisScitani = "0";
        vypisNasobeni = "0";
    }

    // matematicky vypocet jednotlivych cifer
    while (number > 0)
    {
        int cifra = number % 10;

        soucet = soucet + cifra;
        soucin = soucin * cifra;

        vypisScitani = cifra + (vypisScitani == "" ? "" : " + ") + vypisScitani;
        vypisNasobeni = cifra + (vypisNasobeni == "" ? "" : " * ") + vypisNasobeni;

        number = number / 10;
    }

    Console.WriteLine();
    Console.WriteLine("Cifry pro scitani: " + vypisScitani);
    Console.WriteLine("Cifry pro nasobeni: " + vypisNasobeni);

    Console.WriteLine($"Soucet cifer je: {soucet}");
    Console.WriteLine($"Soucin cifer je: {soucin}");

    Console.WriteLine();
    Console.WriteLine("Pro opakovani stisknete klavesu Enter");
    Console.WriteLine("Jakoukoliv jinou ukoncite");
    Console.WriteLine();
    Console.Write("Chcete spustit znovu? : ");

    again = Console.ReadLine() ?? "";
}
