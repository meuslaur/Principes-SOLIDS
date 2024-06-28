using PrincipeO;

Console.WriteLine("SOLID O - Classe ouverte à l'extension mais fermée a la modification.");

List<Forme> list = [];


Square s = new();
s.SideSize = 155;
list.Add(s);

Rectangle r = new();
r.Height = 55;
r.Width = 60;
list.Add(r);

Circle c = new ();
c.Rayon = 42;
list.Add(c);

SurfaceCalculator sc = new ();
int surTot = sc.CompuAllSizes(list);

Console.WriteLine($"Total des surfaces : {surTot}");
