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
    Console.WriteLine();
    Console.WriteLine();  
    Console.WriteLine("Pro opakovani stisknete klavesu Enter");
    Console.WriteLine("jakoukoliv jinou ukoncite");
    Console.WriteLine();
    Console.Write("Chcete spustit znovu? : ");
    again = Console.ReadLine() ?? "";      
}
