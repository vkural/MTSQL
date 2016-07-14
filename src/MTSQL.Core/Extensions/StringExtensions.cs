using System.Text.RegularExpressions;

namespace MTSQL.Core.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNumber(this string str)
        {
            bool result = Regex.IsMatch(str, @"^-?[0-9]\d*(\.\d+)?$");

            return result;
        }
    }
}
