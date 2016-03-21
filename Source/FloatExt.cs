namespace Vector2Extensions
{
	public static class FloatExt
	{
		/// <summary>
		/// given a time in seconds, convert to the number of 1/60 frames per second
		/// </summary>
		/// <param name="seconds"></param>
		/// <returns></returns>
		public static int ToFrames(this float seconds)
		{
			seconds *= 60.0f;
			return (int)(seconds + 0.5f);
		}

		/// <summary>
		/// given a numbner of 1/60 framers per seconds, convert to time in seconds
		/// </summary>
		/// <param name="frames"></param>
		/// <returns></returns>
		public static float ToSeconds(this int frames)
		{
			return ((float)frames / 60.0f);
		}
	}
}