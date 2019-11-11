using System;
using System.Collections.Generic;
using System.Text;

namespace MixedNumberOperations
{
    public class MixedNumber
    {
        public int WholeNumber { get; set; }
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public bool isNegative { get; set; }

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

        public override string ToString()
        {
            if (this.IsZero) return "0";

            if(this.IsWholeNumber == true)
            {
                return (this.isNegative ? "-" : string.Empty) + this.WholeNumber;
            }

            if(this.IsFraction == true)
            {
                return (this.isNegative ? "-" : string.Empty) + this.Numerator + "/" + this.Denominator;
            }

            return (this.isNegative ? "-" : string.Empty) + this.WholeNumber + "_" + this.Numerator + "/" + this.Denominator;

        }
    }
}
