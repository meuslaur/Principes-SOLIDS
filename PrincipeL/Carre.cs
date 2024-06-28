namespace PrincipeL
{
	public class Carre : FormeAvecSurface
	{
		public int SideSize { get; set; }
		public override int Surface => SideSize * SideSize;
	}
}
