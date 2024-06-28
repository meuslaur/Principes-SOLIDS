using PrincipeS;

Console.WriteLine("SOLID S - Une classe doit avoir une et une seule responsabilité.");

Book bk = new();
bk.Title = "Titre du livre";
bk.Author = "Auteur du livre";
bk.NbPages = 235;
bk.ISBN = "125àéèù4778564546";

BookRepository bkr = new ();
Task task = bkr.SaveTofile(bk);

Console.WriteLine("Livre sauvegarder");
 