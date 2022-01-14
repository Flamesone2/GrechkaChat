using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GrechkaServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var host = new ServiceHost(typeof(wcf_GrechkaChat.ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Сервер стартовал!");
                Console.ReadLine();
            }
        }
    }
}
