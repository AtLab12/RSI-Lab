using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WcfClient.ServiceReference1;

namespace WcfClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyData.info();

            Uri baseAddress;

            BasicHttpBinding myBinding = new BasicHttpBinding();
            baseAddress = new Uri("http://10.8.0.6:8080/ServiceBaseName/endpoint1");

            EndpointAddress eAddress = new EndpointAddress(baseAddress);

            ChannelFactory<ICalculator> myCF = new ChannelFactory<ICalculator>(myBinding, eAddress);

            ICalculator myClient = myCF.CreateChannel();
            CalculatorClient myClient2 = new CalculatorClient("WSHttpBinding_ICalculator");


            int option;
            int val1, val2;
            PrintMenu();
            int.TryParse(Console.ReadLine(), out option);
            while (option != 8)
            {
                val1 = getValue();
                val2 = getValue();

                PerformAction(option, val1, val2, myClient2);

                PrintMenu();
                int.TryParse(Console.ReadLine(), out option);
            }

            ((IClientChannel)myClient).Close();
            Console.WriteLine("...Client closed - FINISHED");
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Sub");
            Console.WriteLine("3. Mul");
            Console.WriteLine("4. Div");
            Console.WriteLine("5. Mod");
            Console.WriteLine("6. Primes amount and biggest prime in (x;y)");
            Console.Write("> ");
        }

        private static int getValue()
        {

            Console.WriteLine("Input value:");
            Console.Write("> ");
            int val;
            while (!int.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Input valid value");
                Console.Write("> ");
            }
            return val;
        }

        private static void PerformAction(int option, int val1, int val2, CalculatorClient client)
        {
            try
            {
                int result;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("...using Add");
                        result = client.iAdd(val1, val2);
                        break;
                    case 2:
                        Console.WriteLine("...using Sub");
                        result = client.iSub(val1, val2);
                        break;
                    case 3:
                        Console.WriteLine("...using Mul");
                        result = client.iMul(val1, val2);
                        break;
                    case 4:
                        Console.WriteLine("...using Div");
                        result = client.iDiv(val1, val2);
                        break;
                    case 5:
                        Console.WriteLine("...using Mod");
                        result = client.iMod(val1, val2);
                        break;
                    case 6:
                        Console.WriteLine("...using PrimeAmount");
                        result = 0;
            _ =         CallPrimeCalculation(client, val1, val2);
                        break;
                    default:
                        return;
                }
                if (option != 6 && option != 7)
                    Console.WriteLine("Result (" + val1 + ", " + val2 + ") = " + result);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Wyjątek: " + e.Message);
            }
        }

        private static async Task<double> CallHMultiply(CalculatorClient client, double val1, double val2)
        {
            Console.WriteLine("...... starting Multiply");
            double reply = await client.HMultiplyAsync(val1, val2);
            Console.WriteLine("...... finished Multiply");
            Console.WriteLine("Result (" + val1 + ", " + val2 + ") = " + reply);
            Console.WriteLine(">");

            return reply;
        }

        private static async Task<int> CallPrimeCalculation(CalculatorClient client, int start, int end)
        {
            Console.WriteLine("...starting PrimeAmount");
            Tuple<int, int> reply = await client.PrimeCalculationAsync(start, end);
            Console.WriteLine("...finished PrimeAmount");
            Console.WriteLine("Result (" + start + ", " + end + ") = " + reply);
            Console.WriteLine(">");

            return 0;
        }

    }


}
