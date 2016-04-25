using System.ServiceModel;

namespace WcfServiceContract
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string Echo(string text);

        [OperationContract]
        EchoResponse ComplexEcho(EchoRequest request);
    }
}
