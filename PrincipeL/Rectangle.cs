namespace PrincipeL
{
	public class Rectangle : FormeAvecSurface
	{
		public int Height { get; set; }
		public int Width { get; set; }

		public override int Surface => Height * Width;
	}
}
