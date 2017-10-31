using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using WCF.Contrat.V1;
using WCF.Service.V1;

namespace WCF.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host1 = new ServiceHost(typeof(Service1));            
            host1.Open();
            Console.WriteLine("Le service Majuscule est prêt.");
            foreach (ChannelDispatcher canalDisp in host1.ChannelDispatchers)
            {
                Console.WriteLine(canalDisp.BindingName);
                foreach(var point in canalDisp.Endpoints)
                {
                    Console.WriteLine("\t{0}", point.EndpointAddress);
                }
                Console.WriteLine();
            }
            Console.Read();
            host1.Close(); 

        }
    }
}
