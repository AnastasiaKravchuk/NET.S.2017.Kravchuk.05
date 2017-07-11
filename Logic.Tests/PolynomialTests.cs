using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace Logic.Tests
{
    [TestClass]
    public class PolynomialTests
    {
        [TestMethod]
        public void toString_RandomPolynomial1_ReturnTrue()
        {
            double[] input = new double[] {9, -1, 0, -7, 4};
            double eps = 0.001;
            string expected = "4x^4-7x^3-1x^1+9x^0";
            Polynomial result = new Polynomial(input, eps);

            Assert.AreEqual(expected, result.toString());
        }

        [TestMethod]
        public void toString_RandomPolynomial2_ReturnTrue()
        {
            double[] input = new double[] { 0.9, -4, -0.0001, 0.00001, -0.4, 0.002, -0.007 };
            double eps = 0.001;
            string expected = "-0,007x^6+0,002x^5-0,4x^4-4x^1+0,9x^0";
            Polynomial result = new Polynomial(input, eps);

            Assert.AreEqual(expected, result.toString());
        }

        [TestMethod]
        public void AddOperator_RandomPolynomial34_ReturnTrue()
        {
            double[] input1 = new double[] { 19, 0, 0, -0.45, 0, 4, -0.2, 3 , 0, -8 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 1, 0, 0, -0.5, 0, 0, 18};
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = result1 + result2;

            double[] arrExpected = { 20, 0, 0, -0.95, 0, 4, 17.8, 3, 0, -8 };

            Polynomial sumExpeted = new Polynomial(arrExpected,eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void AddOperator_RandomPolynomial12_ReturnTrue()
        {
            double[] input1 = new double[] { 9, -1, 0, -7, 4 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0.9, -4, -0.0001, 0.00001, -0.4, 0.002, -0.007 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = result1 + result2;

            double[] arrExpected = { 9.9, -5, -0.0001, -7, 3.6, 0.002, -0.007 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void AddOperator_RandomPolynomial56_ReturnTrue()
        {
            double[] input1 = new double[] { 0, 0, -5, 4.5, 0.001, 1.5, 0, -81 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 21, 0, 3, 0, 0, 0, 0, 0, 0, -9, 1 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = result1 + result2;

            double[] arrExpected = { 21, 0, -2, 4.5, 0.001, 1.5, 0, -81, 0, -9, 1 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void AddFunction_RandomPolynomial34_ReturnTrue()
        {
            double[] input1 = new double[] { 19, 0, 0, -0.45, 0, 4, -0.2, 3, 0, -8 };
            double eps = 0.01;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 1, 0, 0, -0.5, 0, 0, 18 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = Polynomial.Add(result1,result2);

            double[] arrExpected = { 20, 0, 0, -0.95, 0, 4, 17.8, 3, 0, -8 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void AddFunction_RandomPolynomial12_ReturnTrue()
        {
            double[] input1 = new double[] { 9, -1, 0, -7, 4 };
            double eps = 0.01;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0.9, -4, -0.0001, 0.00001, -0.4, 0.002, -0.007 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = Polynomial.Add(result1,result2);

            double[] arrExpected = { 9.9, -5, -0.0001, -7, 3.6, 0.002, -0.007 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void AddFunction_RandomPolynomial78_ReturnTrue()
        {
            double[] input1 = new double[] { 0, 0.001, 2.003, 0, 0, -0.0000005, 0, -6.87002, 0, 0, 0.0000001 };
            double eps = 0.0001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0, 0.001, 2.003, 0, 0, -0.0000005, 0, -6.87002, 0, 0, 0.0000001 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = Polynomial.Add(result1, result2);

            double[] arrExpected = { 0, 0.002, 4.006, 0, 0, -0.000001, 0, -13.74004, 0, 0, 0.0000002};

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void Equals_RandomPolynomial78_ReturnTrue()
        {
            double[] input1 = new double[] { 0, 0.001, 2.003, 0, 0, -0.0000005, 0, -6.87002, 0, 0, 0.0000001 };
            double eps = 0.0001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0, 0.001, 2.003, 0, 0, -0.0000005, 0, -6.87002, 0, 0, 0.0000001 };
            Polynomial result2 = new Polynomial(input2, eps);

            Assert.AreEqual(true, result1.Equals(result2));
        }

        [TestMethod]
        public void Equals_RandomPolynomial80_ReturnTrue()
        {
            double[] input1 = new double[] { 0, 0.001, 2.003, 0, 0, -0.0000005, 0, -6.87002, 0, 0, 0.0000001 };
            double eps = 0.0001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0, 0.001, 2.003, 0, 0, 0.0000005, 0, -6.87002, 0, 0, 0.0000001 };
            Polynomial result2 = new Polynomial(input2, eps);

            Assert.AreEqual(true, result1.Equals(result2));
        }

        [TestMethod]
        public void Equals_RandomPolynomial70_ReturnTrue()
        {
            double[] input1 = new double[] { 0, 0.001, 2.003, 0, 0, -0.0000005, 0, -6.87002, 0, 11, 0.0000001 };
            double eps = 0.0001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0, 0.001, 2.003, 0, 0, 0.0000005, 0, -6.87002, 0, 0, 0.0000001 };
            Polynomial result2 = new Polynomial(input2, eps);

            Assert.AreEqual(false, result1.Equals(result2));
        }

        [TestMethod]
        public void Equals_RandomPolynomial12_ReturnTrue()
        {
            double[] input1 = new double[] { 9, -1, 0, -7, 4 };
            double eps = 0.0001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0.9, -4, -0.0001, 0.00001, -0.4, 0.002, -0.007 };
            Polynomial result2 = new Polynomial(input2, eps);

            Assert.AreEqual(false, result1.Equals(result2));
        }

        [TestMethod]
        public void SubtractOperator_RandomPolynomial34_ReturnTrue()
        {
            double[] input1 = new double[] { 19, 0, 0, -0.45, 0, 4, -0.2, 3, 0, -8 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 1, 0, 0, -0.5, 0, 0, 18 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = result1 - result2;

            double[] arrExpected = { 18, 0, 0, 0.05, 0, 4, -18.2, 3, 0, -8 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void SubtractOperator_RandomPolynomial12_ReturnTrue()
        {
            double[] input1 = new double[] { 9, -1, 0, -7, 4 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0.9, -4, -0.0001, 0.00001, -0.4, 0.002, -0.007 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = result1 - result2;

            double[] arrExpected = { 8.1, 3, 0.0001, -7, 4.4, -0.002, 0.007 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void SubtractOperator_RandomPolynomial56_ReturnTrue()
        {
            double[] input1 = new double[] { 0, 0, -5, 4.5, 0.001, 1.5, 0, -81 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 21, 0, 3, 0, 0, 0, 0, 0, 0, -9, 1 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = result1 - result2;

            double[] arrExpected = { -21, 0, -8, 4.5, 0.001, 1.5, 0, -81, 0, 9, -1 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void SubtractFunction_RandomPolynomial34_ReturnTrue()
        {
            double[] input1 = new double[] { 19, 0, 0, -0.45, 0, 4, -0.2, 3, 0, -8 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 1, 0, 0, -0.5, 0, 0, 18 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = Polynomial.Subtract(result1, result2);

            double[] arrExpected = { 18, 0, 0, 0.05, 0, 4, -18.2, 3, 0, -8 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void SubtractFunction_RandomPolynomial12_ReturnTrue()
        {
            double[] input1 = new double[] { 9, -1, 0, -7, 4 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 0.9, -4, -0.0001, 0.00001, -0.4, 0.002, -0.007 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = Polynomial.Subtract(result1,result2);

            double[] arrExpected = { 8.1, 3, 0.0001, -7, 4.4, -0.002, 0.007 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void SubtractFunction_RandomPolynomial56_ReturnTrue()
        {
            double[] input1 = new double[] { 0, 0, -5, 4.5, 0.001, 1.5, 0, -81 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { 21, 0, 3, 0, 0, 0, 0, 0, 0, -9, 1 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = Polynomial.Subtract(result1, result2);

            double[] arrExpected = { -21, 0, -8, 4.5, 0.001, 1.5, 0, -81, 0, 9, -1 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void MultiPlyFunction_PolynomialIntegerCoeff_ReturnTrue()
        {
            double[] input1 = new double[] { 0, 12, 4, 0, 0, -8 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { -6, 1, 0, 0, 1, 0 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = Polynomial.Multiply(result1, result2);

            double[] arrExpected = { 0, -72, -12, 4, 0, 60, -4, 0, 0, -8 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void MultiPlyOperator_PolynomialIntegerCoeff_ReturnTrue()
        {
            double[] input1 = new double[] { -10, 8, 1, 0, 0, 7 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { -6, 8, 0, -7, 23 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = result1*result2;

            double[] arrExpected = { 60, -128, 58, 78, -286, 135, 79, 0, -49, 161 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void MultiPlyFunction_PolynomialRealCoeff_ReturnTrue()
        {
            double[] input1 = new double[] { 10.03, 0, 3.001, 0, 0, 0.01, -0.4 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { -6.19, 0.1, 0, 0, 7.001 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = Polynomial.Multiply(result1, result2);

            double[] arrExpected = { -62.0857, 1.003, -18.57619, 0.3001, 70.22003, -0.0619, 23.487001, -0.04, 0, 0.07001, -2.8004 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void MultiPlyOperation_PolynomialRealCoeff_ReturnTrue()
        {
            double[] input1 = new double[] { 10.03, 0, 3.001, 0, 0, 0.01, -0.4 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double[] input2 = new double[] { -6.19, 0.1, 0, 0, 7.001 };
            Polynomial result2 = new Polynomial(input2, eps);

            Polynomial sumResult = result1 * result2;

            double[] arrExpected = { -62.0857, 1.003, -18.57619, 0.3001, 70.22003, -0.0619, 23.487001, -0.04, 0, 0.07001, -2.8004 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void MultiPlyConstantOperation_PolynomialRealCoeffIntegerConstant_ReturnTrue()
        {
            double[] input1 = new double[] { 10.03, 0, 3.001, 0, 0, 0.01, -0.4 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double k = 6;

            Polynomial sumResult = result1 * k;

            double[] arrExpected = { 60.18, 0, 18.006, 0, 0, 0.06, -2.4 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }

        [TestMethod]
        public void MultiPlyConstantFunction_PolynomialRealCoeffRealConstant_ReturnTrue()
        {
            double[] input1 = new double[] { 10.03, 0, 3.001, 0, 0, 0.01, -0.4 };
            double eps = 0.001;
            Polynomial result1 = new Polynomial(input1, eps);

            double k = 6;

            Polynomial sumResult = Polynomial.MultiplyConst(result1, k);

            double[] arrExpected = { 60.18, 0, 18.006, 0, 0, 0.06, -2.4 };

            Polynomial sumExpeted = new Polynomial(arrExpected, eps);
            Assert.AreEqual(sumResult.toString(), sumExpeted.toString());
        }
    }
}
