using System;
using System.Collections.Generic;
using System.Text;

namespace MixedNumberOperations
{
    public static class MixedNumberHelper
    {
        private static int GetLeastCommonMultiple(int one, int two)
        {
            if (one == 0 && two == 0) return 0;

            var x = one;
            var y = two;
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }

            return (one * two) / x;
        }

        private static int GreatestCommonFactor(int one, int two)
        {
            int remainder;
            while (two != 0)
            {
                remainder = one % two;
                one = two;
                two = remainder;
            }

            return one;
        }

        public static void MultiplyToNumeratorAndDenominator(MixedNumber num, int commonDenominator)
        {
            if (commonDenominator == 0) return;

            var multiplier = commonDenominator / num.Denominator;
            num.Numerator *= multiplier;
            num.Denominator *= multiplier;
        }

        public static MixedNumber Add(MixedNumber one, MixedNumber two)
        {
            if (one.IsZero && two.IsZero) return one;

            if (one.IsZero)
            {
                return two;
            }

            if (two.IsZero)
            {
                return one;
            }

            var result = new MixedNumber();
            if (one.IsWholeNumber && two.IsWholeNumber)
            {
                var oneWholeNumber = one.IsNegative == true ? -1 * one.WholeNumber : one.WholeNumber;
                var twoWholenumber = two.IsNegative == true ? -1 * two.WholeNumber : two.WholeNumber;

                result.WholeNumber = oneWholeNumber + twoWholenumber;

                if (result.WholeNumber < 0)
                {
                    result.WholeNumber *= -1;
                    result.IsNegative = true;
                }

                return result;
            }

            var x = ConvertMixedNumberToFraction(one);
            var y = ConvertMixedNumberToFraction(two);

            Reduce(x);
            Reduce(y);

            if (one.IsWholeNumber == true)
            {
                one.Numerator = two.Denominator * one.WholeNumber;
                one.Denominator = two.Denominator;
                one.WholeNumber = 0;
            }
            else if (two.IsWholeNumber == true)
            {
                two.Numerator = one.Denominator * two.WholeNumber;
                two.Denominator = one.Denominator;
                two.WholeNumber = 0;
            }
            else
            {
                var lcm = GetLeastCommonMultiple(x.Denominator, y.Denominator);
                MultiplyToNumeratorAndDenominator(x, lcm);
                MultiplyToNumeratorAndDenominator(y, lcm);
            }

            var three = new MixedNumber();
            var xNumerator = x.IsNegative ? -1 * x.Numerator : x.Numerator;
            var yNumerator = y.IsNegative ? -1 * y.Numerator : y.Numerator;
            var n = xNumerator + yNumerator;
            if (n == 0)
            {
                return three;
            }
            else if (n < 0)
            {
                three.IsNegative = true;
                n *= -1;
            }

            three.Numerator = n;
            three.Denominator = x.Denominator;
            ConvertToMixedNumber(three);

            return three;
        }

        public static MixedNumber Subtract(MixedNumber one, MixedNumber two)
        {
            if (one.IsZero && two.IsZero) return one;
            if(one.IsZero)
            {
                two.IsNegative = !two.IsNegative;
                return two;
            }

            if(two.IsZero)
            {
                return one;
            }

            var result = new MixedNumber();
            if (one.IsWholeNumber && two.IsWholeNumber)
            {
                var oneWholeNumber = one.IsNegative == true ? -1 * one.WholeNumber : one.WholeNumber;
                var twoWholenumber = two.IsNegative == true ? -1 * two.WholeNumber : two.WholeNumber;

                result.WholeNumber = oneWholeNumber - twoWholenumber;

                if(result.WholeNumber == 0)
                {
                    result.IsNegative = false;
                }
                else if(result.WholeNumber < 0)
                {
                    result.WholeNumber *= -1;
                    result.IsNegative = true;
                }

                return result;
            }

            var x = ConvertMixedNumberToFraction(one);
            var y = ConvertMixedNumberToFraction(two);

            Reduce(x);
            Reduce(y);

            if (one.IsWholeNumber == true)
            {
                one.Numerator = two.Denominator * one.WholeNumber;
                one.Denominator = two.Denominator;
                one.WholeNumber = 0;
            }
            else if (two.IsWholeNumber == true)
            {
                two.Numerator = one.Denominator * two.WholeNumber;
                two.Denominator = one.Denominator;
                two.WholeNumber = 0;
            }
            else
            {
                var lcm = GetLeastCommonMultiple(x.Denominator, y.Denominator);
                MultiplyToNumeratorAndDenominator(x, lcm);
                MultiplyToNumeratorAndDenominator(y, lcm);
            }

            var three = new MixedNumber();
            var xNumerator = x.IsNegative ? -1 * x.Numerator : x.Numerator;
            var yNumerator = y.IsNegative ? -1 * y.Numerator : y.Numerator;
            var n = xNumerator - yNumerator;
            if(n == 0)
            {
                return three;
            }
            else if (n < 0)
            {
                three.IsNegative = true;
                n *= -1;
            }

            three.Numerator = n;
            three.Denominator = x.Denominator;
            ConvertToMixedNumber(three);

            return three;
        }

        public static MixedNumber Multiply(MixedNumber one, MixedNumber two)
        {
            if (one.IsZero || two.IsZero) return one;

            var result = new MixedNumber();
            if (one.IsWholeNumber && two.IsWholeNumber)
            {
                var oneWholeNumber = one.IsNegative == true ? -1 * one.WholeNumber : one.WholeNumber;
                var twoWholenumber = two.IsNegative == true ? -1 * two.WholeNumber : two.WholeNumber;

                result.WholeNumber = oneWholeNumber * twoWholenumber;

                if (result.WholeNumber < 0)
                {
                    result.WholeNumber *= -1;
                    result.IsNegative = true;
                }

                return result;
            }

            if (one.IsWholeNumber == true)
            {
                one.Numerator = two.Denominator * one.WholeNumber;
                one.Denominator = two.Denominator;
                one.WholeNumber = 0;
            }
            else if (two.IsWholeNumber == true)
            {
                two.Numerator = one.Denominator * two.WholeNumber;
                two.Denominator = one.Denominator;
                two.WholeNumber = 0;
            }

            var x = ConvertMixedNumberToFraction(one);
            var y = ConvertMixedNumberToFraction(two);

            result = new MixedNumber();
            result.Numerator = x.Numerator * y.Numerator;
            result.Denominator = x.Denominator * y.Denominator;
            result.IsNegative = true;
            if ((x.IsNegative == true && y.IsNegative == true) || (x.IsNegative == false && y.IsNegative == false))
            {
                result.IsNegative = false;
            }

            Reduce(result);
            ConvertToMixedNumber(result);

            return result;
        }

        public static MixedNumber Divide(MixedNumber one, MixedNumber two)
        {
            if (two.IsZero) throw new ArgumentException(nameof(two));
            if (one.IsZero) return one;

            var result = new MixedNumber();
            if (one.IsWholeNumber && two.IsWholeNumber)
            {
                result.Numerator = one.WholeNumber;
                result.Denominator = two.WholeNumber;
                result.IsNegative = true;
                if ((one.IsNegative == true && two.IsNegative == true) || (one.IsNegative == false && two.IsNegative == false))
                {
                    result.IsNegative = false;
                }

                Reduce(result);
                ConvertToMixedNumber(result);
                return result;
            }

            if (one.IsWholeNumber == true)
            {
                one.Numerator = two.Denominator * one.WholeNumber;
                one.Denominator = two.Denominator;
                one.WholeNumber = 0;
            }
            else if (two.IsWholeNumber == true)
            {
                two.Numerator = one.Denominator * two.WholeNumber;
                two.Denominator = one.Denominator;
                two.WholeNumber = 0;
            }

            var x = ConvertMixedNumberToFraction(one);
            var y = ConvertMixedNumberToFraction(two);

            var temp = y.Numerator;
            y.Numerator = y.Denominator;
            y.Denominator = temp;

            result = new MixedNumber();
            result.Numerator = x.Numerator * y.Numerator;
            result.Denominator = x.Denominator * y.Denominator;
            result.IsNegative = true;
            if((x.IsNegative == true && y.IsNegative == true) || (x.IsNegative == false && y.IsNegative == false))
            {
                result.IsNegative = false;
            }

            Reduce(result);
            ConvertToMixedNumber(result);

            return result;
        }

        public static MixedNumber ConvertMixedNumberToFraction(MixedNumber num)
        {
            if (!num.IsMixedNumber) return num;

            var result = new MixedNumber();
            result.IsNegative = num.IsNegative;
            result.WholeNumber = 0;
            result.Numerator = (num.WholeNumber * num.Denominator) + num.Numerator;
            result.Denominator = num.Denominator;

            return result;
        }

        public static void ConvertToMixedNumber(MixedNumber num)
        {
            if(num.IsWholeNumber || num.IsProperFraction)
            {
                return;
            }

            var remainder = num.Numerator % num.Denominator;
            var quotient = num.Numerator / num.Denominator;

            num.WholeNumber += quotient;
            num.Numerator = remainder;
            if (remainder == 0) num.Denominator = 0;
        }

        public static void Reduce(MixedNumber num)
        {
            if (num.IsWholeNumber) return;

            var gcf = GreatestCommonFactor(num.Numerator, num.Denominator);

            if (gcf == 0) return;

            num.Numerator /= gcf;
            num.Denominator /= gcf;
        }
    }
}
