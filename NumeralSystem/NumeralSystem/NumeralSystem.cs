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
            Stack<char> result = new Stack<char>();
            uint radix = (uint)digits.Length;
            while (!(n < digits.Length))
            {
                var indx = n % (radix);
                result.Push(digits[indx]);
                n /= radix;
            }
            result.Push(digits[n]);
            return result.ToArray();
        }
        public string ToDigitsStr(uint n)=> new string(ToDigits(n));
    }
}
