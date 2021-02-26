using System;
using System.ServiceModel;

using Service;

namespace Host
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine ("Init WCF host");
            var binding = new BasicHttpBinding();
            var address = new Uri("http://127.0.0.1:9091");
            var host = new ServiceHost(typeof(CalcService));
            host.AddServiceEndpoint(
                typeof(ICalcService),
                binding,
                address
            );

            host.Open();

            Console.WriteLine("Serving. Press Enter to exit.");
            Console.ReadLine();
            host.Close();
        }
    }
}
