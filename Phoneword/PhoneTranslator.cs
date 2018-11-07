using System;
using System.Text;
namespace Phoneword
{
    public static class PhoneTranslator
    {
        public PhoneTranslator()
        {
        }

        public static string ToNumber(string raw) {
            if (string.IsNullOrWhiteSpace(raw)) {
                return null;
            }

            raw = raw.ToUpperInvariant();

            var newNumber = new StringBuilder();
            foreach (var c in raw) 
            {
                if (" -0123456789".Contains(c))
                    newNumber.Append(c);
                else
                {
                    var result = TranslateToNumber(c);
                    if (result != null)
                        newNumber.Append(result);
                    else
                        return null;
                }
            }
            return newNumber.ToString();
        }
    }
}
