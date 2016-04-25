using System;
using System.ServiceModel;
using WcfServiceContract;

namespace Client.Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();

            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:45066/echo.svc");

            ChannelFactory<IEchoService> channelFactory = new ChannelFactory<IEchoService>(basicHttpBinding, endpointAddress);

            IEchoService client = channelFactory.CreateChannel();
            string response = client.Echo("test");

            Console.WriteLine(response.ToString());
            ((IClientChannel)client).Close();

            channelFactory.Close();

            Console.ReadKey();
        }
    }
}
