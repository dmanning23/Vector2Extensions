using Microsoft.Xna.Framework;
using System;

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

		/// <summary>
		/// Given a vector, get the vector perpendicular to that vect
		/// </summary>
		/// <param name="myVector"></param>
		/// <returns></returns>
		public static Vector2 Perp(this Vector2 myVector)
		{
			return new Vector2(-myVector.Y, myVector.X);
		}

		/// <summary>
		/// returns positive if v2 is clockwise of this vector,
		/// negative if anticlockwise (assuming the Y axis is pointing down, X axis to right like a Window app)
		/// </summary>
		/// <param name="myVector"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static int Sign(this Vector2 myVector, Vector2 v2)
		{
			if ((myVector.Y * v2.X) > (myVector.X * v2.Y))
			{
				return -1;
			}
			else
			{
				return 1;
			}
		}

		/// <summary>
		/// If a vector is longer than the max length, chop it off
		/// </summary>
		/// <param name="myVector"></param>
		/// <param name="maxLength"></param>
		/// <returns></returns>
		public static Vector2 Truncate(this Vector2 myVector, float maxLength)
		{
			if (myVector.LengthSquared() > (maxLength * maxLength))
			{
				myVector.Normalize();
				myVector *= maxLength;
			}

			return myVector;
		}

		/// <summary>
		/// Given 2 lines in 2D space AB, CD this returns true if an intersection occurs 
		/// and sets dist to the distance the intersection occurs along AB. 
		/// Also sets the 2d vector point to the point of intersection
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="C"></param>
		/// <param name="D"></param>
		/// <param name="dist"></param>
		/// <param name="point"></param>
		/// <returns></returns>
		public static bool LineIntersection2D(Vector2 A,
									   Vector2 B,
									   Vector2 C,
									   Vector2 D,
									   ref float dist,
									   ref Vector2 point)
		{

			float rTop = (A.Y - C.Y) * (D.X - C.X) - (A.X - C.X) * (D.Y - C.Y);
			float rBot = (B.X - A.X) * (D.Y - C.Y) - (B.Y - A.Y) * (D.X - C.X);

			float sTop = (A.Y - C.Y) * (B.X - A.X) - (A.X - C.X) * (B.Y - A.Y);
			float sBot = (B.X - A.X) * (D.Y - C.Y) - (B.Y - A.Y) * (D.X - C.X);

			if ((rBot == 0.0f) || (sBot == 0.0f))
			{
				//lines are parallel
				return false;
			}

			float r = rTop / rBot;
			float s = sTop / sBot;

			if ((r > 0) && (r < 1) && (s > 0) && (s < 1))
			{
				dist = Vector2.Distance(A, B) * r;

				point = A + r * (B - A);

				return true;
			}
			else
			{
				dist = 0;

				return false;
			}
		}
	}
}
