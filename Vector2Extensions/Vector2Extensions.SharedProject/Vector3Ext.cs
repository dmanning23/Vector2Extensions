using Microsoft.Xna.Framework;
using RandomExtensions;
using System;

namespace Vector2Extensions
{
	public static class Vector3Ext
	{
		/// <summary>
		/// Given a string of two numbers separated by a space, get a 2d vector
		/// This method takes a string created from Vector2.StringFromVector() and does the reverse
		/// </summary>
		/// <param name="strVector">the vector string</param>
		/// <returns>a 2d vector with the values from the string!</returns>
		public static Vector3 ToVector3(this string strVector)
		{
			Vector3 myVector = Vector3.Zero;

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
				if (pathinfo.Length >= 3)
				{
					myVector.Z = Convert.ToSingle(pathinfo[2]);
				}
			}

			return myVector;
		}

		/// <summary>
		/// Extension method to simply convert between vector2 and string
		/// </summary>
		/// <returns>string created from the vector</returns>
		/// <param name="myVector">A vector to convert to string</param>
		public static string StringFromVector(this Vector3 myVector)
		{
			return $"{myVector.X.ToString()} {myVector.Y.ToString()} {myVector.Z.ToString()}";
		}

		/// <summary>
		/// Get a random vector2 within the specified constraints
		/// </summary>
		/// <param name="rand"></param>
		/// <param name="minX"></param>
		/// <param name="maxX"></param>
		/// <param name="minY"></param>
		/// <param name="maxY"></param>
		/// <returns></returns>
		public static Vector3 NextVector3(this Random rand, float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
		{
			return new Vector3(rand.NextFloat(minX, maxX), rand.NextFloat(minY, maxY), rand.NextFloat(minZ, maxZ));
		}
	}
}
