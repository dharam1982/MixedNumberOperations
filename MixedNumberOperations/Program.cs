using System;

namespace MixedNumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });

            // whole numbers only
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, isNegative = true });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, isNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, isNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, isNegative = true });

            // mixed numbers only
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 2, Numerator = 1, Denominator = 4 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 2, Numerator = 1, Denominator = 4, isNegative = true });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 2 }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 2, isNegative = true });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, isNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 1, Denominator = 4 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, isNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 1, Denominator = 4, isNegative = true });

            // whole and mixed number
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 2, Numerator = 1, Denominator = 4 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 2, Numerator = 1, Denominator = 4, isNegative = true });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, isNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 1, Denominator = 4 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, isNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 1, Denominator = 4, isNegative = true });

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, isNegative = true });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, isNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 });
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, isNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, isNegative = true });

            //x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            //x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 4 }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3 });
            //x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
        }
    }
}
