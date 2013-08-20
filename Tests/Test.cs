using NUnit.Framework;
using System;
using Microsoft.Xna.Framework;
using Vector2Extensions;

namespace Vector2Extensions.Tests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void testToString()
		{
			Vector2 test = new Vector2(1.1f, 2.2f);
			string strTest = test.StringFromVector();
			Vector2 test1 = strTest.ToVector2();
			Assert.AreEqual(1.1f, test1.X);
			Assert.AreEqual(2.2f, test1.Y);
		}

		[Test()]
		public void VectZero()
		{
			Vector2 test = Vector2.Zero;
			string strTest = test.StringFromVector();
			Vector2 test1 = strTest.ToVector2();
			Assert.AreEqual(0.0f, test1.X);
			Assert.AreEqual(0.0f, test1.Y);
		}

		[Test()]
		public void NullString()
		{
			string strTest = "";
			Vector2 test1 = strTest.ToVector2();
			Assert.AreEqual(0.0f, test1.X);
			Assert.AreEqual(0.0f, test1.Y);
		}

		[Test()]
		public void NumAndNaNString()
		{
			Vector2 test = new Vector2(1.5f, float.NaN);
			string strTest = test.StringFromVector();
			Vector2 test1 = strTest.ToVector2();
			Assert.AreEqual(1.5f, test1.X);
			Assert.AreEqual(float.NaN, test1.Y);
		}

		[Test()]
		public void NaNString()
		{
			Vector2 test = new Vector2(float.NaN, float.NaN);
			string strTest = test.StringFromVector();
			Vector2 test1 = strTest.ToVector2();
			Assert.AreEqual(float.NaN, test1.X);
			Assert.AreEqual(float.NaN, test1.Y);
		}

		[Test()]
		public void BullshitString()
		{
			string strTest = "buttnuts";
			Vector2 test1 = Vector2.Zero;
			try
			{
				test1 = strTest.ToVector2();
			}
			catch
			{
			}
			Assert.AreEqual(0.0f, test1.X);
			Assert.AreEqual(0.0f, test1.Y);
		}
	}
}

