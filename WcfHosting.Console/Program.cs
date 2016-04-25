using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WcfHosting.SelfHosted
{
    class Program
    {
        static void Main(string[] args)
        {
            //HostHttpService();

            using (ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary.EchoService)))
            {
                host.Open();

                Console.WriteLine("The service is ready at {0}", host.BaseAddresses[0]);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }

        private static void HostHttpService()
        {
            Uri baseAddress = new Uri("http://localhost:8082/echo");
            using (ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary.EchoService), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
