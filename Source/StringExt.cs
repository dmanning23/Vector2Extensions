using System;
using System.Collections.Generic;

namespace Vector2Extensions
{
	public static class StringExt
	{
		/// <summary>
		/// given a big dumb string, convert it to an array of integers
		/// </summary>
		/// <param name="strValue"></param>
		/// <returns></returns>
		public static int[] ToIntArray(this string strValue)
		{
			List<int> myInts = new List<int>();

			if (!string.IsNullOrEmpty(strValue))
			{
				//tokenize teh string
				string[] pathinfo = strValue.Split(new Char[] { ' ', '\n', '\t' });

				for (int i = 0; i < pathinfo.Length; i++)
				{
					myInts.Add(Convert.ToInt32(pathinfo[i]));
				}
			}

			return myInts.ToArray();
		}
	}
}
