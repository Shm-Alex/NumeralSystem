namespace NumeralSystem
{
    public class NumeralSystem
    {
        private readonly char[] digits;

        public NumeralSystem(char[] alphaBit)
        {
            this.digits = alphaBit;
            if (alphaBit == null || alphaBit.Length == 0) throw new ArgumentNullException(nameof(alphaBit));

        }
        public char[] ToDigits(uint n)
        {
            List<char> result = new List<char>();
            uint radix = (uint)digits.Length;
            while (!(n < digits.Length))
            {
                var indx = n % (radix);
                result.Add(digits[indx]);
                n /= radix;
            }
            result.Add(digits[n]);
            return result.ToArray();
        }
    }
}
