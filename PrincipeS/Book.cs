using System.Text.Json;

namespace PrincipeS
{
	public class Book
	{
		public string Title { get; set; } = "";
		public string Author { get; set; } = "";
		public int NbPages { get; set; }
		public string ISBN { get; set; } = "";
	}
}
