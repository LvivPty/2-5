using System.ServiceModel;

namespace Microsoft.ServiceModel.Samples
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IRemoteService
    {
        [OperationContract]
        string Ping();

        [OperationContract]
        string Echo(string text);

        [OperationContract]
        bool Login(string name, string pass);
    }
}
