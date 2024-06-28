using PrincipeI;

Console.WriteLine("SOLID I");
Console.WriteLine("Utilisez plusieurs petites Interfaces plutôt qu'une méga Interface qui fait tout.");

void DisplayAllBooks(IRepositoryRead repo)
{
    Console.WriteLine("Liste des livres");
    var books = repo.GetAll();
	foreach (var book in books)
	{
		Console.WriteLine(book.Title);
	}
}


BookRepository br = new();

Book bo = new Book();
bo.Id = 1;
bo.Title = "Titre 1";
bo.Author = "Auteur 1";
bo.NbPages = 100;
bo.ISBN = "12544878778";
br.Add(bo);

Book bp = new Book();
bp.Id = 1;
bp.Title = "Titre 2";
bp.Author = "Auteur 2";
bp.NbPages = 150;
bp.ISBN = "GARFGDTETTETE";
br.Add(bp);

DisplayAllBooks(br);