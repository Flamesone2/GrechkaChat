using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_GrechkaChat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceChat : IServiceChat
    {

        List<User> users = new List<User>();
        int nextId = 1;

        static string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/GrechkaChat/UserData.json";
        UsersData[] userData = JsonConvert.DeserializeObject<UsersData[]>(File.ReadAllText(path));

        public int Connect(string name)
        {
            User user = new User() { id = nextId, name = name, operationContext = OperationContext.Current };
            nextId++;

            SendMsg(" " + user.name + " подключился!", 0);
            users.Add(user);
            Console.WriteLine($"Юзеров: {users.Count}");
            return user.id;
        }


        public void Disconnect(int id)
        {
            var user = users.FirstOrDefault(i => i.id == id);
            if (user != null)
            {
                users.Remove(user);
                SendMsg(" " + user.name + " отключился!", 0);
                Console.WriteLine($"Юзеров: {users.Count}");
            }
        }

        public void SendMsg(string msg, int id)
        {
            foreach (var item in users)
            {
                string answer = DateTime.Now.ToShortTimeString();
                var user = users.FirstOrDefault(i => i.id == id);
                if (user != null)
                {
                    answer += $" - {user.name}: ";
                }

                answer += msg;

                item.operationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(answer);
            }
        }

        public void AutorisationCheck(string login, string password)
        {
            for (int i = 0; i < userData.Length; i++)
            {
                if (userData[i].login == login && userData[i].password == password)
                {
                    OperationContext.Current.GetCallbackChannel<IServerChatCallback>().AutCallBack(true, "");
                    break;
                }
                else
                {
                    if (i == userData.Length - 1)
                    {
                        OperationContext.Current.GetCallbackChannel<IServerChatCallback>().AutCallBack(false, "Неверный логин или пароль!");
                    }
                }
            }
        }

        public void RegistrationCheck(string login, string password)
        {

            UsersData[] newData = null;
            bool success = false;

            for (int i = 0; i < userData.Length; i++)
            {
                if (userData[i].login != login)
                {
                    if (i == userData.Length - 1)
                    {
                        newData = new UsersData[userData.Length + 1];
                        Array.Copy(userData, newData, userData.Length);

                        newData[i + 1] = new UsersData();
                        newData[i+1].login = login;
                        newData[i+1].password = password;

                        success = true;

                        OperationContext.Current.GetCallbackChannel<IServerChatCallback>().AutCallBack(true, "");
                        
                    }
                }
                else
                {
                    OperationContext.Current.GetCallbackChannel<IServerChatCallback>().AutCallBack(false, "Такой пользователь уже существует!");
                    break;
                }
  
            }

            if (success)
            {
                userData = new UsersData[newData.Length];
                Array.Copy(newData, userData, newData.Length);
                File.Create(path).Close();
                File.WriteAllText(path, JsonConvert.SerializeObject(userData));
            }
        }

        public void NumberOfUsers()
        {
            int numOfUsers = users.Count;
            foreach (var item in users)
            {   
                item.operationContext.GetCallbackChannel<IServerChatCallback>().NumberOfUsersCallBack(numOfUsers);
            }
        }

        public void SendUserList()
        {
            string[] usersList = new string[users.Count];
            int i = 0;
            foreach (var item in users)
            {
                usersList[i] = item.name;
                i++;
            }
            OperationContext.Current.GetCallbackChannel<IServerChatCallback>().UserListCallBack(usersList);
        }
    }
}
