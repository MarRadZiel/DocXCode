namespace DoxXCode.Utility
{
    public static class Extensions
    {
        public static int Count(this string text, char character)
        {
            int count = 0;
            for (int i = 0; i < text.Length; ++i)
            {
                if (text[i].Equals(character))
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
