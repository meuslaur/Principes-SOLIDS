namespace PrincipeL
{
	public class SurfaceCalculator
	{
		public int CompuAllSizes( IEnumerable<FormeAvecSurface> formes )
		{
			int result = 0;
			foreach ( var forme in formes )
			{
				result += forme.Surface;
			}
			return result;
		}
		/*private int ComputeSize( Shape shape )
		{
			return shape switch
			{
				Square s => s.SideSize * s.SideSize,
				Rectangle r => r.Width * r.Height,
				_ => throw new NotImplementedException()
			};*/
			/*if ( shape is Square c )
			{
				return c.SideSize * c.SideSize;
			}else if( shape is Rectangle r )
			{
				return r.Width * r.Height;
			}
			throw new NotImplementedException();
		}*/
	}
}
