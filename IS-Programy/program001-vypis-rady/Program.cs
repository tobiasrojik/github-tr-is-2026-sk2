// See https://aka.ms/new-console-template for more information
Console.WriteLine("!");
// jako prvni si pripravime smycku pro opakovaní programu

string again = "a";
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("***************** Vypis řady *******************");
    Console.WriteLine("************************************************");

    //Console.WriteLine("Zadejte prvni cislo rady: ");
    //int first = int.Parse(Console.ReadLine());
    Console.WriteLine("Zadejte prvni cislo (cele rady)");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo,Zadejte prvni cislo (cele rady)");
    }

    Console.WriteLine("Zadejte posledni cislo (cele rady)");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo,Zadejte posledni cislo (cele rady)");
    }

    Console.Write("Zadejte diferenci (kladne cele cislo)");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Diference musí být kladné celé číslo! zadejte znovu");
    }

    Console.WriteLine();
    Console.WriteLine();  
    Console.WriteLine("Pro opakovani stisknete klavesu Enter");
    Console.WriteLine("jakoukoliv jinou ukoncite");
    Console.WriteLine();
    Console.Write("Chcete spustit znovu? : ");
    again = Console.ReadLine() ?? "";      
}
