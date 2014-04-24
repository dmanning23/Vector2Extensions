using Microsoft.Xna.Framework;

namespace Vector2Extensions
{
	public static class PointExt
	{
		public static Vector2 ToVector2(this Point point)
		{
			return new Vector2(point.X, point.Y);
		}
	}
}
