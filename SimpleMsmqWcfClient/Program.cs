using SimpleMsmqWcf;
using System;
using System.Messaging;
using System.ServiceModel;

namespace SimpleMsmqWcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpointAddress = "net.msmq://localhost/private/SimpleMsmqWcfQueue";

            String strPath = ".\\private$\\SimpleMsmqWcfQueue";
            if(!MessageQueue.Exists(strPath)){
                MessageQueue.Create(strPath,true);
            }
            
            NetMsmqBinding binding = new NetMsmqBinding(NetMsmqSecurityMode.None);
           
            EndpointAddress myEndpoint = new EndpointAddress(endpointAddress);

            ChannelFactory<IServiceContract> channel = new ChannelFactory<IServiceContract>(binding, myEndpoint);
            IServiceContract  service = channel.CreateChannel();
            try
            {
                service.SendMessage($"The current time is " + new Random().Next(10).ToString());
                //service.SendNumber(DateTime.Now.Ticks);
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);                
            }
            
            Console.WriteLine("Client is running ....");
            Console.WriteLine("Messages was sent....");
            Console.ReadLine();
        }
    }
}
