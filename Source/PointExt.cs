using Microsoft.Xna.Framework;
using System;

namespace Vector2Extensions
{
	public static class PointExt
	{
		public static Vector2 ToVector2(this Point point)
		{
			return new Vector2(point.X, point.Y);
		}

		public static Point ToPoint(this Vector2 vect)
		{
			return new Point((int)vect.X, (int)vect.Y);
		}

		/// <summary>
		/// Given a string of two numbers separated by a space, get a 2d vector
		/// This method takes a string created from Vector2.StringFromVector() and does the reverse
		/// </summary>
		/// <param name="strVector">the vector string</param>
		/// <returns>a 2d vector with the values from the string!</returns>
		public static Point ToPoint(this string strPoint)
		{
			Point mine = Point.Zero;

			if (!string.IsNullOrEmpty(strPoint))
			{
				//tokenize teh string
				string[] pathinfo = strPoint.Split(new Char[] { ' ' });
				if (pathinfo.Length >= 1)
				{
					mine.X = Convert.ToInt32(pathinfo[0]);
				}
				if (pathinfo.Length >= 2)
				{
					mine.Y = Convert.ToInt32(pathinfo[1]);
				}
			}

			return mine;
		}

		/// <summary>
		/// Extension method to simply convert between point and string
		/// </summary>
		/// <returns>string created from the point</returns>
		/// <param name="pt">A point to convert to string</param>
		public static string StringFromPoint(this Point pt)
		{
			return pt.X.ToString() + " " + pt.Y.ToString();
		}
	}
}
