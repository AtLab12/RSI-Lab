using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfService;


namespace WcfServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyData.info();
            Uri baseAddress = new Uri("http://localhost:8080/ServiceBaseName");

            ServiceHost myHost = new ServiceHost(typeof(MyCalculator), baseAddress);

            BasicHttpBinding myBinding = new BasicHttpBinding();
            ServiceEndpoint endpoint1 = myHost.AddServiceEndpoint(typeof(ICalculator), myBinding, "endpoint1");

            WSHttpBinding binding2 = new WSHttpBinding();
            binding2.Security.Mode = SecurityMode.None;
            ServiceEndpoint endpoint2 = myHost.AddServiceEndpoint(typeof(ICalculator), binding2, "endpoint2");

            try
            {
                myHost.Open();
                Console.WriteLine("-->Service started.");
                Console.WriteLine("-->Press <ENTER> to STOP service...");
                Console.WriteLine();
                Console.ReadLine();
                myHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("-->Exception occured: {0}", ce.Message);
                myHost.Abort();
            }
        }
    }
}
