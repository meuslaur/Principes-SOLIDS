namespace PrincipeI
{
	public interface IRepositoryRead
	{
		Book? GetById( int id );
		IEnumerable<Book> GetAll();
	}
}
