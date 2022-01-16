using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GrechkaServer
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/GrechkaChat";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Директория базы данных создана по пути: {path}");
            }

            if (!File.Exists($"{path}/UserData.json"))
            {
                UsersData[] userData = new UsersData[1];
                userData[0] = new UsersData
                {
                    login = "",
                    password = ""
                };

                File.Create($"{path}/UserData.json");
                Console.WriteLine($"{path}/UserData.json");
                File.WriteAllText($"{path}/UserData.json", JsonConvert.SerializeObject(userData));
            }

            using (var host = new ServiceHost(typeof(wcf_GrechkaChat.ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Сервер стартовал!");

                Console.ReadLine();
            }
        }
    }
}
