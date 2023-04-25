using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using WcfService;

namespace WcfService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class MyCalculator : ICalculator
    {
        public double Add(double val1, double val2)
        {
            double result = val1 + val2;
            try
            {
                PrintCall("Add", val1, val2, result);
                return result;

            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }

        }

        public double Multiply(double val1, double val2)
        {
            try
            {
                double result = val1 * val2;
                PrintCall("Multiply", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public double Divide(double val1, double val2)
        {
            try
            {
                double result = val1 / val2;
                PrintCall("Divide", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public double Substract(double val1, double val2)
        {
            try
            {
                double result = val1 - val2;
                PrintCall("Substract", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public double Mod(double val1, double val2)
        {
            try
            {
                double result = val1 % val2;
                PrintCall("Mod", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public double HMultiply(double val1, double val2)
        {
            try
            {
                Thread.Sleep(1000);
                double result = val1 * val2;
                PrintCall("Multiply", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public int iAdd(int val1, int val2)
        {
            try
            {
                int result = checked(val1 + val2);
                PrintCall("Add", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public int iSub(int val1, int val2)
        {
            try
            {
                int result = checked(val1 - val2);
                PrintCall("Sub", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public int iMul(int val1, int val2)
        {
            try
            {
                int result = checked(val1 * val2);
                PrintCall("Mul", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public int iDiv(int val1, int val2)
        {

            try
            {
                int result = checked(val1 / val2);
                PrintCall("Div", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public int iMod(int val1, int val2)
        {
            try
            {
                int result = val1 % val2;
                PrintCall("Mod", val1, val2, result);
                return result;
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        public Tuple<int, int> PrimeCalculation(int val1, int val2)
        {
            try
            {
                if (val2 < val1) throw new OperationException("Zły zakres");
                bool[] primes = new bool[val2 + 1];

                for (int i = 2; i <= val2; i++)
                {
                    primes[i] = true;
                }

                for (int p = 2; p * p <= val2; p++)
                {
                    if (primes[p])
                    {
                        for (int i = p * p; i <= val2; i += p)
                        {
                            primes[i] = false;
                        }
                    }
                }

                int count = 0;
                for (int i = val1; i <= val2; i++)
                {
                    if (primes[i])
                    {
                        count++;
                    }
                }

                PrintCall("PrimesAmount", val1, val2, count);

                bool[] primes2 = new bool[val2 + 1];
                for (int i = 2; i <= val2; i++)
                {
                    primes2[i] = true;
                }

                for (int i = 2; i <= Math.Sqrt(val2); i++)
                {
                    if (primes2[i])
                    {
                        for (int j = i * i; j <= val2; j += i)
                        {
                            primes2[j] = false;
                        }
                    }
                }

                int biggestPrime = 0;
                for (int i = val2; i >= val1; i--)
                {
                    if (primes2[i])
                    {
                        biggestPrime = i;
                        break;
                    }
                }

                PrintCall("BiggestPrime", val1, val2, biggestPrime);
                return Tuple.Create(count, biggestPrime);
            }
            catch (Exception ex)
            {
                throw new OperationException(ex.Message);
            }
        }

        private void PrintCall(string method, double val1, double val2, double result)
        {
            Console.WriteLine("Used function: " + method + "(" + val1.ToString() + "," + val2.ToString() + ") = " + result.ToString());
        }
    }
}
