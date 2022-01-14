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
            User user = new User() { id = nextId, userName = name, operationContext = OperationContext.Current };
            nextId++;

            SendMsg(user.userName + " подключился!");
            users.Add(user);
            return user.id;
        }


        public void Disconnect(int id)
        {
            throw new NotImplementedException();
        }

        public void SendMsg(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
