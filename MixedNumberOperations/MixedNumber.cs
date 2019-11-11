using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MixedNumberOperations
{
    public class MixedNumber
    {
        private int wholeNumber;
        private int numerator;
        private int denominator;

        public MixedNumber()
        {
        }

        public MixedNumber(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException(nameof(input));
            }

            input = input.Trim();
            Regex r = new Regex(@"[-]{1}\d{1,4}_{1}\d{1,4}/{1}\d{1,4}");
            var matches = r.Matches(input);
            if (matches.Count == 1 && matches[0].Length == input.Length)
            {
                var splitNumbers = matches[0].Value.Split('-', '_', '/');
                IsNegative = true;
                WholeNumber = int.Parse(splitNumbers[1]);
                Numerator = int.Parse(splitNumbers[2]);
                Denominator = int.Parse(splitNumbers[3]);
                return;
            }

            r = new Regex(@"\d{1,4}_{1}\d{1,4}/{1}\d{1,4}");
            matches = r.Matches(input);
            if (matches.Count == 1 && matches[0].Length == input.Length)
            {
                var splitNumbers = matches[0].Value.Split('_', '/');
                WholeNumber = int.Parse(splitNumbers[0]);
                Numerator = int.Parse(splitNumbers[1]);
                Denominator = int.Parse(splitNumbers[2]);
                return;
            }

            r = new Regex(@"[-]{1}\d{1,4}/{1}\d{1,4}");
            matches = r.Matches(input);
            if (matches.Count == 1 && matches[0].Length == input.Length)
            {
                var splitNumbers = matches[0].Value.Split('-', '/');
                IsNegative = true;
                Numerator = int.Parse(splitNumbers[1]);
                Denominator = int.Parse(splitNumbers[2]);
                return;
            }

            r = new Regex(@"\d{1,4}/{1}\d{1,4}");
            matches = r.Matches(input);
            if (matches.Count == 1 && matches[0].Length == input.Length)
            {
                var splitNumbers = matches[0].Value.Split('/');
                Numerator = int.Parse(splitNumbers[0]);
                Denominator = int.Parse(splitNumbers[1]);
                return;
            }

            r = new Regex(@"[-]{1}\d{1,4}");
            matches = r.Matches(input);
            if (matches.Count == 1 && matches[0].Length == input.Length)
            {
                var splitNumbers = matches[0].Value.Split('-');
                IsNegative = true;
                WholeNumber = int.Parse(splitNumbers[1]);
                return;
            }

            r = new Regex(@"\d{1,4}");
            matches = r.Matches(input);
            if (matches.Count == 1 && matches[0].Length == input.Length)
            {
                WholeNumber = int.Parse(matches[0].Value);
                return;
            }

            throw new ArgumentException("Invalid Mixed number format.");
        }

        public int WholeNumber {
            get
            {
                return wholeNumber;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("No negative numbers.");
                }

                wholeNumber = value;
            }
        }

        public int Numerator
        {
            get
            {
                return numerator;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No negative numbers.");
                }

                numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No negative numbers.");
                }

                denominator = value;
            }
        }

        public bool IsNegative { get; set; }

        public bool IsWholeNumber
        {
            get
            {
                return Numerator == 0 && Denominator == 0;
            }
        }

        public bool IsMixedNumber
        {
            get
            {
                return WholeNumber != 0 && Numerator != 0 && Denominator != 0;
            }
        }

        public bool IsFraction
        {
            get
            {
                return WholeNumber == 0 && Numerator != 0 && Denominator != 0;
            }
        }

        public bool IsProperFraction
        {
            get
            {
                return WholeNumber == 0 && Numerator != 0 && Denominator != 0 & Numerator < Denominator;
            }
        }

        public bool IsImproperFraction
        {
            get
            {
                return WholeNumber == 0 && Numerator != 0 && Denominator != 0 & Numerator > Denominator;
            }
        }

        public bool IsZero
        {
            get
            {
                return Numerator == 0 && Denominator == 0 && WholeNumber == 0;
            }
        }

        public static MixedNumber Zero
        {
            get
            {
                return new MixedNumber();
            }
        }

        public override string ToString()
        {
            if (this.IsZero) return "0";

            if(this.IsWholeNumber == true)
            {
                return (this.IsNegative ? "-" : string.Empty) + this.WholeNumber;
            }

            if(this.IsFraction == true)
            {
                return (this.IsNegative ? "-" : string.Empty) + this.Numerator + "/" + this.Denominator;
            }

            return (this.IsNegative ? "-" : string.Empty) + this.WholeNumber + "_" + this.Numerator + "/" + this.Denominator;

        }

        public MixedNumber Clone()
        {
            var x = new MixedNumber();
            x.IsNegative = IsNegative;
            x.WholeNumber = WholeNumber;
            x.Numerator = Numerator;
            x.Denominator = Denominator;
            return x;
        }
    }
}
