using System.Text.Encodings.Web;
using System.Text.Json;

namespace PrincipeD;

public class BookRepository : IRepository
{
	private List<Book> books=new();
	public void Add( Book book ) => books.Add(book);
	public void Update( Book book )
	{
		books.RemoveAll(b => b.Id == book.Id);
	}
	public void Delete( Book book ) => books.Remove(book);

	public IEnumerable<Book> GetAll() => books;

	public Book? GetById( int id ) => books.FirstOrDefault(b => b.Id == id);

	public Task Save() => Task.CompletedTask;

	public async Task SaveTofile( Book book )
	{
		await File.WriteAllTextAsync($"./book-{book.Title}.json",
			JsonSerializer.Serialize(book, new JsonSerializerOptions
			{
				PropertyNameCaseInsensitive = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			}));
	}
}
