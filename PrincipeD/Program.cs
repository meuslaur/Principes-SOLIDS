using PrincipeD;

Console.WriteLine("SOLID D");
Console.WriteLine("Stipule qu'il faut dépendre d'abstractions et non d'implémentations");


BookManager(new FileRepository());

void BookManager(FileRepository repo)
{
	// Menu à gérer
	// 1. récupérer les livres
	repo.GetAll();	

	// ...
}