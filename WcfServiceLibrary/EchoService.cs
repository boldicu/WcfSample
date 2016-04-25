using System;
using WcfServiceContract;

namespace WcfServiceLibrary
{
    public class EchoService : IEchoService
    {
        public EchoResponse ComplexEcho(EchoRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("EchoRequest");
            }

            EchoResponse response = new EchoResponse() { IsChannelOpen = true, Text = string.Format("{0} - {1}", request.UserName, request.Text) };
            return response;
        }

        public string Echo(string text)
        {
            return text;
        }
    }
}
