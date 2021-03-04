using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;

public class HelloWorldRest
{
    static readonly string RestServiceBaseAddress = "http://localhost:9092";

    [ServiceContract]
    public interface IRestInterface
    {
        [OperationContract, WebGet]
        string HelloWorld();
    }

    public class RestService : IRestInterface
    {
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }

    public static void Main()
    {
        ServiceHost restHost = new ServiceHost(typeof(RestService), new Uri(RestServiceBaseAddress));
        restHost.AddServiceEndpoint(typeof(IRestInterface), new WebHttpBinding(), "").Behaviors.Add(new WebHttpBehavior());
        restHost.Open();
        Console.WriteLine("Serving. Press Enter to exit.");
        Console.ReadLine();
        restHost.Close();

    }
}
