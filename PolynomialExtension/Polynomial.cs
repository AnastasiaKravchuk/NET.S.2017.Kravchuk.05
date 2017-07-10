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

        public Polynomial(){}

        public Polynomial(double[] arr)
        {
            SetCoefficients(arr);
        }

        private void SetCoefficients(double[] arr)
        {
            coeff = arr;
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
                str += arr[i].ToString();
                str += " x^";
                str += i.ToString();
                if(i > 0)
                {
                    str += " + ";
                }
            }
            Console.WriteLine(str);
        }

        public static Polynomial operator +(Polynomial first, Polynomial second)
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
                sum[i] = temp1 + temp2;
            }
            return new Polynomial(sum);
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
