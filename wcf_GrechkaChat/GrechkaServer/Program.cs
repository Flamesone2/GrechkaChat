using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/GrechkaChat";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"Директория базы данных создана по пути: {path}");
                }

                if(!File.Exists($"{path}/UserData.json"))
                {
                    File.Create($"{path}/UserData.json");
                    Console.WriteLine($"{path}/UserData.json");
                }


                Console.ReadLine();
            }
        }
    }
}
