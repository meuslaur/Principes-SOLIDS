namespace PrincipeD
{
	public interface IRepositoryWrite
	{
		void Add( Book book );
		void Update( Book book );
		void Delete( Book book );
		Task Save();
	}
}
