using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Polynomial
    {
        private double[] coeff;
        private double accuracy;

        public Polynomial(){}

        public Polynomial(double[] arr)
        {
            SetCoefficients(arr);
        }

        public Polynomial(double[] arr, double eps)
        {
            SetCoefficients(arr, eps);
        }

        private void SetCoefficients(double[] arr)
        {
            coeff = arr;
        }

        private void SetCoefficients(double[] arr, double eps)
        {
            double[] res = new double[arr.Length];
            accuracy = eps;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > accuracy)
                {
                    res[i] = arr[i];
                }
            }
            coeff = res;
        }

        private double[] GetCoefficients()
        {
            return coeff;
        }

        public int GetDegree()
        {
            return this.coeff.Length;
        }

        public void toString()
        {
            String str = "";
            int n = coeff.Length;
            double[] arr = coeff;
            for (int i = n - 1; i >= 0 ; i--)
            {
                if (arr[i] > accuracy)
                {
                    str += arr[i].ToString();
                    str += " x^";
                    str += i.ToString();
                    if (i > 0 && arr[i-1] > accuracy)
                    {
                        str += " + ";
                    }
                }
            }
            Console.WriteLine(str);
        }

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

        public static Polynomial Add(Polynomial lhs, Polynomial rhs)
        {
            return lhs + rhs;
        }

        public static Polynomial operator -(Polynomial first, Polynomial second)
        {
            int l = Math.Max(first.GetDegree(), second.GetDegree());

            double[] sum = new double[l];
            double temp1, temp2;
            for (int i = 0; i < l; i++)
            {
                if (i < first.GetDegree()) { temp1 = first.GetCoefficients()[i]; }
                else { temp1 = 0; }

                if (i < second.GetDegree()) { temp2 = second.GetCoefficients()[i]; }
                else { temp2 = 0; }
                sum[i] = temp1 - temp2;
            }
            return new Polynomial(sum);
        }

        public static Polynomial Subtract(Polynomial lhs, Polynomial rhs)
        {
            return lhs - rhs;
        }

        public static Polynomial operator *(Polynomial obj, double constant)
        {
            int n = obj.GetDegree();
            double[] res = new double[n];
            for (int i = 0; i < n; i++)
            {
                res[i] *= constant;
            }
            return new Polynomial(res);
        }

        public static Polynomial MultiplyConst(Polynomial obj, double k)
        {
            return obj * k;
        }

        public static Polynomial Multiply(Polynomial lhs, Polynomial rhs)
        {
            return lhs*rhs;
        }

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

        public bool Equals(Polynomial obj)
        {
            Polynomial poly = obj as Polynomial;

            for (int i = 0; i < obj.GetDegree(); i++)
            {
                if (coeff[i] != obj.GetCoefficients()[i])
                {
                    return false;
                }
            }
            return true;
        }

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
