namespace Tasks
{
    public static class StringExtentions
    {
        public static string ToSentenceCase(this string input)
        {
            if (input.Length < 1)
                return input;

            string sentence = input.ToLower();
            return sentence[0].ToString().ToUpper() +
               sentence.Substring(1);
        }
    }
}
