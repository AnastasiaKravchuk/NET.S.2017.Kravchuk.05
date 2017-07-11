using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Polynomial
    {
        /// <summary>
        /// Two fields of the Polynomial class: 
        ///  - coeff  - array of polynomial coefficients;
        ///  - accuracy - accuracy of polynomial coefficients;
        /// </summary>
        private double[] coeff;
        private double accuracy;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Polynomial(){}

        /// <summary>
        /// Constructor which uses SetCoefficients(arr)
        /// </summary>
        /// <param name="arr"></param>
        public Polynomial(double[] arr)
        {
            SetCoefficients(arr);
        }

        /// <summary>
        /// Constructor which uses SetCoefficients(arr, accuracy)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="eps"></param>
        public Polynomial(double[] arr, double eps)
        {
            SetCoefficients(arr, eps);
        }

        /// <summary>
        /// Sets a value for double[] coeff field
        /// </summary>
        /// <param name="arr"></param>
        private void SetCoefficients(double[] arr)
        {
            coeff = arr;
        }

        /// <summary>
        /// Sets values for double[] coeff and double accuracy fields
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="eps"></param>
        private void SetCoefficients(double[] arr, double eps)
        {
            double[] res = new double[arr.Length];
            accuracy = eps;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > accuracy)
                {
                    res[i] = arr[i];
                }
            }
            coeff = res;
        }

        /// <summary>
        /// Gets a value of double[] coeff field
        /// </summary>
        /// <returns></returns>
        private double[] GetCoefficients()
        {
            return coeff;
        }

        /// <summary>
        /// Gets a degree of polynomial + 1
        /// (gets a length of coefficients' array)
        /// </summary>
        /// <returns></returns>
        public int GetDegree()
        {
            return this.coeff.Length;
        }

        /// <summary>
        /// Returns a string representation of the object
        /// </summary>
        public string toString()
        {
            String str = "";
            int n = coeff.Length;
            double[] arr = coeff;
            for (int i = n - 1; i >= 0 ; i--)
            {
                if (Math.Abs(arr[i]) > accuracy)
                {
                    str += arr[i].ToString();
                    str += "x^";
                    str += i.ToString();
                    if (i > 0 && (arr[i - 1] > accuracy))
                    {
                        str += "+";
                    }
                }
            }
            return str;
        }

        /// <summary>
        /// Returns the sum of two polynomials
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns></returns>
        public static Polynomial operator +(Polynomial lhs, Polynomial rhs)
        {
            int l = Math.Max(lhs.GetDegree(), rhs.GetDegree());
            
            double[] sum = new double[l];
            double temp1, temp2;
            for (int i = 0; i < l; i++)
            {
                if (i < lhs.GetDegree()) { temp1 = lhs.GetCoefficients()[i]; }
                    else { temp1 = 0; }

                if (i < rhs.GetDegree()) { temp2 = rhs.GetCoefficients()[i]; }
                    else { temp2 = 0; }
                sum[i] = temp1 + temp2;
            }
            return new Polynomial(sum);
        }

        /// <summary>
        /// Returns the sum of two polynomials
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns></returns>
        public static Polynomial Add(Polynomial lhs, Polynomial rhs)
        {
            return lhs + rhs;
        }

        /// <summary>
        /// Returns the difference of two polynomials
        /// </summary>
        /// <param name="first">First object</param>
        /// <param name="second">Second object</param>
        /// <returns></returns>
        public static Polynomial operator -(Polynomial lhs, Polynomial rhs)
        {
            int l = Math.Max(lhs.GetDegree(), rhs.GetDegree());

            double[] sum = new double[l];
            double[] rhsTemp = CreateSubtrahend(rhs);

            double temp1, temp2;
            for (int i = 0; i < l; i++)
            {
                if (i < lhs.GetDegree()) { temp1 = lhs.GetCoefficients()[i]; }
                else { temp1 = 0; }

                if (i < rhs.GetDegree()) { temp2 = rhsTemp[i]; }
                else { temp2 = 0; }
                sum[i] = temp1 + temp2;
            }
            return new Polynomial(sum);
        }

        /// <summary>
        /// Creates an array of obj.Coeff values with opposite signs
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static double[] CreateSubtrahend(Polynomial obj)
        {
            int n = obj.GetDegree();
            double[] res = new double[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = -obj.GetCoefficients()[i];
            }
            return res;
        }

        /// <summary>
        /// Returns the difference of two polynomials
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns></returns>
        public static Polynomial Subtract(Polynomial lhs, Polynomial rhs)
        {
            return lhs - rhs;
        }

        /// <summary>
        /// Returns the product of polynomial and constant
        /// </summary>
        /// <param name="obj">Object</param>
        /// <param name="constant">Constant</param>
        /// <returns></returns>
        public static Polynomial operator *(Polynomial obj, double constant)
        {
            int n = obj.GetDegree();
            double[] res = new double[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = constant* obj.GetCoefficients()[i];
            }
            return new Polynomial(res);
        }

        /// <summary>
        /// Returns the product of polynomial and constant
        /// </summary>
        /// <param name="obj">Object</param>
        /// <param name="k">Constant</param>
        /// <returns></returns>
        public static Polynomial MultiplyConst(Polynomial obj, double k)
        {
            return obj * k;
        }

        /// <summary>
        /// Returns the product of two polynomials
        /// </summary>
        /// <param name="lhs">First object</param>
        /// <param name="rhs">Second object</param>
        /// <returns></returns>
        public static Polynomial Multiply(Polynomial lhs, Polynomial rhs)
        {
            return lhs*rhs;
        }

        /// <summary>
        /// Returns the product of two polynomials
        /// </summary>
        /// <param name="obj1">First object</param>
        /// <param name="obj2">Second object</param>
        /// <returns></returns>
        public static Polynomial operator *(Polynomial obj1, Polynomial obj2)
        {
            int l1 = obj1.GetDegree(); int l2 = obj2.GetDegree();
            int l = l1 * l2;
            double[] res = new double[l];
            for (int i = 0; i < l1; i++)
            {
                for (int j = 0; j < l2; j++)
                {
                    res[i+j] += obj1.GetCoefficients()[i]*obj2.GetCoefficients()[j];
                }
            }
            return new Polynomial(res);
        }

        /// <summary>
        /// Test two objects for coefficients' array equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(Polynomial obj)
        {
            for (int i = 0; i < obj.GetDegree(); i++)
            {
                if (coeff[i] != obj.GetCoefficients()[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Overridden GetHashCode() method
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hash = 17;
            for (int i = 0; i < coeff.Length; i++)
            {
                hash = hash * 23 + coeff[i].GetHashCode();
            }
            return hash;
        }
    }
}
