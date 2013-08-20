using System;
using Microsoft.Xna.Framework;

namespace Vector2Extensions
{
	public static class Vector2Ext
	{
		/// <summary>
		/// Given a string of two numbers separated by a space, get a 2d vector
		/// This method takes a string created from Vector2.StringFromVector() and does the reverse
		/// </summary>
		/// <param name="strVector">the vector string</param>
		/// <returns>a 2d vector with the values from the string!</returns>
		public static Vector2 ToVector2(this string strVector)
		{
			Vector2 myVector = Vector2.Zero;

			if (!string.IsNullOrEmpty(strVector))
			{
				//tokenize teh string
				string[] pathinfo = strVector.Split(new Char[] { ' ' });
				if (pathinfo.Length >= 1)
				{
					myVector.X = Convert.ToSingle(pathinfo[0]);
				}
				if (pathinfo.Length >= 2)
				{
					myVector.Y = Convert.ToSingle(pathinfo[1]);
				}
			}

			return myVector;
		}

		/// <summary>
		/// Extension method to simply convert between vector2 and string
		/// </summary>
		/// <returns>string created from the vector</returns>
		/// <param name="myVector">A vector to convert to string</param>
		public static string StringFromVector(this Vector2 myVector)
		{
			return myVector.X.ToString() + " " + myVector.Y.ToString();
		}
	}
}
