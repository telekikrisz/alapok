Console.WriteLine("Kérem a tanuló nevét:");

string TanuloNeve = Console.ReadLine();
Console.WriteLine("Kérem a tanuló pontszámát:");
int TanuloPontszama = int.Parse(Console.ReadLine());
int maxPontszam = 97;
double szazalekosErtek = (double)TanuloPontszama / maxPontszam * 100;
//szazalekosErtek=Math.Round(szazalekosErtek, 0);
Console.WriteLine($"Tanuló neve: {TanuloNeve}");
Console.WriteLine($"Eredmény: {TanuloPontszama}/{maxPontszam} ({szazalekosErtek:F0}%)");
if (szazalekosErtek >= 50) Console.WriteLine("Státusz: Sikeres dolgozat!");
else Console.WriteLine("Státusz: Sikertelen dolgozat!");
