using System;
using System.ServiceModel;

namespace SimpleMsmqWcf
{
    [ServiceContract(Namespace = "http://MyServices/IServiceContract")]
    public interface IServiceContract
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
        [OperationContract(IsOneWay = true)]
        void SendNumber(long message);
    }
    public class ServiceContract : IServiceContract
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now} [{nameof(SendMessage)}]: {message}");
        }

        public void SendNumber(long message)
        {
            Console.WriteLine($"{DateTime.Now} [{nameof(SendNumber)}]: {message}");
        }
    }
}
