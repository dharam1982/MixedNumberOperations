using Microsoft.VisualStudio.TestTools.UnitTesting;
using MixedNumberOperations;

namespace MixedNumverOperations.Test
{
    [TestClass]
    public class MixedNumberHelperTests
    {
        [TestMethod]
        public void AddTestMethod()
        {
            // whole numbers only
            var x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("2", x.ToString(), "case 1");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("0", x.ToString(), "case 2");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("0", x.ToString(), "case 3");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("-1", x.ToString(), "case 4");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("1", x.ToString(), "case 5");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 , IsNegative = true}, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-1", x.ToString(), "case 6");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 3, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("1", x.ToString(), "case 7");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("-3", x.ToString(), "case 8");

            // mixed numbers only
            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("2_2/3", x.ToString(), "case 9");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 2, Denominator = 3 });
            Assert.AreEqual("3", x.ToString(), "case 10");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("0", x.ToString(), "case 11");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("1", x.ToString(), "case 12");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("0", x.ToString(), "case 13");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("-1/12", x.ToString(), "case 14");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("1/12", x.ToString(), "case 15");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("-1/12", x.ToString(), "case 16");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("1/12", x.ToString(), "case 17");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("-2_7/12", x.ToString(), "case 18");

            // whole and mixed number
            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("2_1/3", x.ToString(), "case 19");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("2/3", x.ToString(), "case 20");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 , IsNegative= true}, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("-2/3", x.ToString(), "case 21");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-1/3", x.ToString(), "case 22");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("-2/3", x.ToString(), "case 23");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("-2_1/4", x.ToString(), "case 24");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("-2_1/4", x.ToString(), "case 25");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("0", x.ToString(), "case 26");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("1_1/3", x.ToString(), "case 27");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("1_1/3", x.ToString(), "case 28");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 27");

            x = MixedNumberHelper.Add(new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 28");
        }

        [TestMethod]
        public void SubtractTestMethod()
        {
            // whole numbers only
            var x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("0", x.ToString(), "case 1");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("2", x.ToString(), "case 2");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-2", x.ToString(), "case 3");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("3", x.ToString(), "case 4");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("3", x.ToString(), "case 5");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-3", x.ToString(), "case 6");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 3, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-5", x.ToString(), "case 7");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("1", x.ToString(), "case 8");

            // mixed numbers only
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("0", x.ToString(), "case 9");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 2, Denominator = 3 });
            Assert.AreEqual("-1/3", x.ToString(), "case 10");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("2_2/3", x.ToString(), "case 11");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("1_2/3", x.ToString(), "case 12");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("-2_2/3", x.ToString(), "case 13");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("2_7/12", x.ToString(), "case 14");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("2_7/12", x.ToString(), "case 15");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("-2_7/12", x.ToString(), "case 16");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("-2_7/12", x.ToString(), "case 17");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("-1/12", x.ToString(), "case 18");

            // whole and mixed number
            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("-1/3", x.ToString(), "case 19");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("1_1/3", x.ToString(), "case 20");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 21");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-2_1/3", x.ToString(), "case 22");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 0, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 23");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("1/4", x.ToString(), "case 24");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("-1/4", x.ToString(), "case 25");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("0", x.ToString(), "case 26");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("1_1/3", x.ToString(), "case 27");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 28");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 29");

            x = MixedNumberHelper.Subtract(new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true });
            Assert.AreEqual("1_1/3", x.ToString(), "case 30");
        }

        [TestMethod]
        public void MultiplyTestMothod()
        {
            var x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("0", x.ToString(), "case 0");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("1", x.ToString(), "case 1");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 3, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-6", x.ToString(), "case 2");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 3, Numerator = 0, Denominator = 0, IsNegative =  true });
            Assert.AreEqual("-6", x.ToString(), "case 3");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 3, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("6", x.ToString(), "case 14");


            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("1_2/3", x.ToString(), "case 5");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("-1_2/3", x.ToString(), "case 6");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("-1_2/3", x.ToString(), "case 7");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("1_2/3", x.ToString(), "case 8");


            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("1_1/4", x.ToString(), "case 9");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("1_1/3", x.ToString(), "case 10");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 11");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("-1_1/4", x.ToString(), "case 12");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3}, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 13");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("-1_1/4", x.ToString(), "case 14");

            x = MixedNumberHelper.Multiply(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("1_2/3", x.ToString(), "case 15");
        }

        [TestMethod]
        public void DivideTestMothod()
        {
            var x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("1", x.ToString(), "case 1");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 3, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-2/3", x.ToString(), "case 2");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 3, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("-2/3", x.ToString(), "case 3");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 2, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 3, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("2/3", x.ToString(), "case 4");


            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("1_1/15", x.ToString(), "case 5");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("-1_1/15", x.ToString(), "case 6");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("-1_1/15", x.ToString(), "case 7");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("1_1/15", x.ToString(), "case 8");


            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("4/5", x.ToString(), "case 9");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("1_1/3", x.ToString(), "case 10");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 11");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("-4/5", x.ToString(), "case 12");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3 }, new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true });
            Assert.AreEqual("-1_1/3", x.ToString(), "case 13");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 0, Denominator = 0, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4 });
            Assert.AreEqual("-4/5", x.ToString(), "case 14");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 3, IsNegative = true }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("1_1/15", x.ToString(), "case 15");

            x = MixedNumberHelper.Divide(new MixedNumber { WholeNumber = 0, Numerator = 0, Denominator = 0 }, new MixedNumber { WholeNumber = 1, Numerator = 1, Denominator = 4, IsNegative = true });
            Assert.AreEqual("0", x.ToString(), "case 16");
        }
    }
}
