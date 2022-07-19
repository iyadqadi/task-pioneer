using System;

namespace Tasks
{

    public static class IntExtentions
    {
        public static string ToText(this int number)
        {
            if (Enum.IsDefined(typeof(Number), number))
            {
                Number num = (Number)number;
                return num.ToString();
            }
            else if (number < 100)
            {
                int once = number % 10;
                Tens ten = (Tens)(number - once);
                return ten.ToString() + (once != 0 ? "-" + once.ToText() : "");
            }
            else if (number < 1000)
            {
                int tens = number % 100;
                int hunders = number / 100;
                return hunders.ToText() + " hundred " + (tens != 0 ? tens.ToText() : "");
            }
            if (number < 1000000)
            {
                return (number / 1000).ToText() + " thousand " + ((number % 1000) != 0 ? (number % 1000).ToText() : "");
            }
            if (number < 1000000000)
            {
                return (number / 1000000).ToText() + " million " + ((number % 1000000) != 0 ? (number % 1000000).ToText() : "");
            }
            else
            {
                return (number / 1000000000).ToText() + " billion " + ((number % 1000000000) != 0 ? (number % 1000000000).ToText() : "");
            }

        }
    }
}
