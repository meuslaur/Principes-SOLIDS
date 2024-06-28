namespace PrincipeL
{
	public class Cercle : FormeAvecSurface
	{
		public int Rayon;
		public override int Surface => (Rayon * Rayon) * 3;
	}
}
