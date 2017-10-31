using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            host1.AddServiceEndpoint(
                typeof(IService1),
                new NetTcpBinding(),
                "net.tcp://Parme22/localhost1234/ServiceMajuscule"
                );

            host1.Open();
            Console.WriteLine("Le service Majuscule est prêt.");
            Console.Read();
            host1.Close(); 
            dfjghgihgi

        }
    }
}
