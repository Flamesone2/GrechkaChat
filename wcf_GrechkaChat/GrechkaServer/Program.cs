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

                //File.Create($"{path}/UserData.json");

                using(FileStream fstream = new FileStream($"{path}/UserData.json", FileMode.Create))
                {
                    fstream.Close();
                }

                Stream myStream;

                using (myStream = File.Open($"{path}/UserData.json", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    StreamWriter myWriter = new StreamWriter(myStream);
                    myWriter.Write(JsonConvert.SerializeObject(userData));
                    myWriter.Close();
                    Console.WriteLine("Бд обновлена");
                }

                Console.WriteLine($"{path}/UserData.json");
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
