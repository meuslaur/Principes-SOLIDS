namespace PrincipeO
{
	public class Rectangle : Forme
	{
		public int Height { get; set; }
		public int Width { get; set; }

		public override int Surface => Height * Width;
	}
}
