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

		[Test()]
		public void TruncateTest()
		{
			Vector2 vec = new Vector2(100.0f, 100.0f);
			vec = vec.Truncate(1.0f);
			Assert.AreEqual(1.0f, Math.Round(vec.Length(), 4));
		}

		[Test()]
		public void TruncateTest2()
		{
			Vector2 vec = new Vector2(100.0f, 100.0f);
			vec = vec.Truncate(2.0f);
			Assert.AreEqual(2.0f, Math.Round(vec.Length(), 4));
		}

		[Test()]
		public void Angle0()
		{
			Vector2 vec = new Vector2(1.0f, 0.0f);
			Assert.AreEqual(0.0f, Math.Round(vec.Angle(), 4));
		}

		[Test()]
		public void Angle90()
		{
			Vector2 vec = new Vector2(0.0f, 1.0f);
			float desiredAngle = MathHelper.ToRadians(90.0f);
			desiredAngle = (float)Math.Round(desiredAngle, 4);
			Assert.AreEqual(desiredAngle, (float)Math.Round(vec.Angle(), 4));
		}

		[Test()]
		public void AngleMinus45()
		{
			Vector2 vec = new Vector2(1.0f, -1.0f);
			float desiredAngle = MathHelper.ToRadians(-45.0f);
			desiredAngle = (float)Math.Round(desiredAngle, 4);
			Assert.AreEqual(desiredAngle, (float)Math.Round(vec.Angle(), 4));
		}

		[Test()]
		public void AngleMinus45_1()
		{
			Vector2 vec = new Vector2(100.0f, -100.0f);
			float desiredAngle = MathHelper.ToRadians(-45.0f);
			desiredAngle = (float)Math.Round(desiredAngle, 4);
			Assert.AreEqual(desiredAngle, (float)Math.Round(vec.Angle(), 4));
		}

		[Test()]
		public void Angle180()
		{
			Vector2 vec = new Vector2(-1.0f, 0.0f);
			float desiredAngle = MathHelper.ToRadians(180.0f);
			desiredAngle = (float)Math.Round(desiredAngle, 4);
			Assert.AreEqual(desiredAngle, (float)Math.Round(vec.Angle(), 4));
		}

		[Test()]
		public void AngleBetween0()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(1.0f, 0.0f);
			Assert.AreEqual(0.0f, (float)Math.Round(vec1.AngleBetweenVectors(vec2), 4));
		}

		[Test()]
		public void AngleBetween90()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(0.0f, 1.0f);
			float desiredAngle = vec1.AngleBetweenVectors(vec2);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);
			Assert.AreEqual(90.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetween90_1()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(0.0f, 1.0f);
			float desiredAngle = vec2.AngleBetweenVectors(vec1);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);
			Assert.AreEqual(-90.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetweenMinus90()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(0.0f, -1.0f);

			float desiredAngle = vec1.AngleBetweenVectors(vec2);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);

			Assert.AreEqual(-90.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetweenMinus90_1()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(0.0f, -1.0f);

			float desiredAngle = vec2.AngleBetweenVectors(vec1);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);

			Assert.AreEqual(90.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetween180()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(-1.0f, 0.0f);

			float desiredAngle = vec1.AngleBetweenVectors(vec2);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);

			Assert.AreEqual(180.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetween180_1()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(-1.0f, 0.0f);

			float desiredAngle = vec2.AngleBetweenVectors(vec1);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);

			Assert.AreEqual(-180.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetweenMinus180()
		{
			Vector2 vec1 = new Vector2(-1.0f, 0.0f);
			Vector2 vec2 = new Vector2(1.0f, 0.0f);

			float desiredAngle = vec1.AngleBetweenVectors(vec2);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);

			Assert.AreEqual(-180.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetweenMinus180_1()
		{
			Vector2 vec1 = new Vector2(-1.0f, 0.0f);
			Vector2 vec2 = new Vector2(1.0f, 0.0f);

			float desiredAngle = vec2.AngleBetweenVectors(vec1);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);

			Assert.AreEqual(180.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetween45()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(1.0f, 1.0f);

			float desiredAngle = vec1.AngleBetweenVectors(vec2);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);

			Assert.AreEqual(45.0f, desiredAngle);
		}

		[Test()]
		public void AngleBetween45_1()
		{
			Vector2 vec1 = new Vector2(1.0f, 0.0f);
			Vector2 vec2 = new Vector2(1.0f, 1.0f);

			float desiredAngle = vec2.AngleBetweenVectors(vec1);
			desiredAngle = MathHelper.ToDegrees(desiredAngle);
			desiredAngle = (float)Math.Round(desiredAngle, 4);

			Assert.AreEqual(-45.0f, desiredAngle);
		}
	}
}

