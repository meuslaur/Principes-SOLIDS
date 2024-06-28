namespace PrincipeO
{
	internal class Circle : Forme
	{
		public int Rayon;
		public override int Surface => (Rayon * Rayon) * 3;
	}
}
