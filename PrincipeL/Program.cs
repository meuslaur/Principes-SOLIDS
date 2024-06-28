using PrincipeL;

Console.WriteLine("SOLID L");
Console.WriteLine("Toute classe plus spécifique passée à une méthode qui attends une classe plus générique \r\nne doit pas casser le comportement");


List<FormeAvecSurface> lst = new();

Rectangle r =new();				// Classe spécifique avec surface
r.Width = 66;
r.Height = 125;
lst.Add(r);

Cercle c = new Cercle();
c.Rayon = 25;
lst.Add(c);

/*Ligne l = new Ligne();			Classe spécifique sans surface
l.Longueur = 23399;
lst.Add(l);*/

SurfaceCalculator sc = new();
int tot = sc.CompuAllSizes(lst);
Console.WriteLine($"Total des surfaces : {tot}");
