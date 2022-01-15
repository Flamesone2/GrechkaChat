using System;
using System.Collections.Generic;
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
            foreach(var item in users)
            {
                string answer = DateTime.Now.ToShortTimeString();
                var user = users.FirstOrDefault(i => i.id == id);
                if(user != null)
                {
                    answer += $" - {user.name} :";
                }

                answer += msg;

                item.operationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(answer);
            }
        }
    }
}
