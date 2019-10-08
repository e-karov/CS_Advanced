using System;

namespace Shopping_Spree
{
    public static class Validator
    {

        public static void ValidateText(string text, string name = null)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException($"{name} cannot be empty");
            }
        }

        public static void ValidateMoney(decimal money, string name = null)
        {
            if (money < 0)
            {
                throw new ArgumentException($"Money cannot be negative");
            }
        }
    }

    
}
