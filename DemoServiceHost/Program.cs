using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DemoServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(DemoService.DemoService)))
            {
                host.Open();
                Console.WriteLine($"Host is started {DateTime.Now.ToString()}");
                Console.ReadLine();
            }
        }
    }
}
