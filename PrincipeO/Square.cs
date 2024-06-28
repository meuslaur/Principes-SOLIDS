namespace PrincipeO
{
	public class Square : Forme
	{

		public int SideSize { get; set; }

		public override int Surface => SideSize * SideSize;
	}
}
