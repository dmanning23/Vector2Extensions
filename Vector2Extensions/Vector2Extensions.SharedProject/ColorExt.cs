using Microsoft.Xna.Framework;
using System;

namespace Vector2Extensions
{
	public static class ColorExt
	{
		/// <summary>
		/// Given a string of two numbers separated by a space, get a 2d vector
		/// This method takes a string created from Vector2.StringFromVector() and does the reverse
		/// </summary>
		/// <param name="strVector">the vector string</param>
		/// <returns>a 2d vector with the values from the string!</returns>
		public static Color ToColor(this string color)
		{
			var myColor = Color.White;

			if (!string.IsNullOrEmpty(color))
			{
				//tokenize teh string
				string[] pathinfo = color.Split(new Char[] { ' ' });
				if (pathinfo.Length >= 1)
				{
					myColor.R = Convert.ToByte(pathinfo[0]);
				}
				if (pathinfo.Length >= 2)
				{
					myColor.G = Convert.ToByte(pathinfo[1]);
				}
				if (pathinfo.Length >= 3)
				{
					myColor.B = Convert.ToByte(pathinfo[2]);
				}
				if (pathinfo.Length >= 4)
				{
					myColor.A = Convert.ToByte(pathinfo[3]);
				}
			}

			return myColor;
		}

		/// <summary>
		/// Extension method to simply convert between vector2 and string
		/// </summary>
		/// <returns>string created from the vector</returns>
		/// <param name="myVector">A vector to convert to string</param>
		public static string StringFromColor(this Color color)
		{
			return $"{color.R.ToString()} {color.G.ToString()} {color.B.ToString()} {color.A.ToString()}";
		}
	}
}
