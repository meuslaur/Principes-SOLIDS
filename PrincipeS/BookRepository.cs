using System.Text.Encodings.Web;
using System.Text.Json;

namespace PrincipeS
{
	public class BookRepository
	{
		public async Task SaveTofile( Book book )
		{
			await File.WriteAllTextAsync($"./book-{book.Title}.json",
				JsonSerializer.Serialize(book, new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true,
					Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				}));
		}

		public class WeatherForecast
		{
			public DateTimeOffset Date { get; set; }
			public int TemperatureCelsius { get; set; }
			public string? Summary { get; set; }
		}
		public async Task EcrireFichierAsync()
		{
			var weatherForecast = new WeatherForecast
			{
				Date = DateTime.Parse("2019-08-01"),
				TemperatureCelsius = 25,
				Summary = "Hot"
			};

			string fileName = "./WeatherForecast.json";
			await using FileStream createStream = File.Create(fileName);
			await JsonSerializer.SerializeAsync(createStream, weatherForecast);

			Console.WriteLine(File.ReadAllText(fileName));
		}
	}
}
