using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_GrechkaChat
{
    [ServiceContract(CallbackContract = typeof(IServerChatCallback))]
    public interface IServiceChat
    {
        [OperationContract]
        int Connect(string name);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)]
        void SendMsg(string msg, int id);

        [OperationContract(IsOneWay = true)]
        void AutorisationCheck(string login, string password);

        [OperationContract(IsOneWay = true)]
        void RegistrationCheck(string login, string password);

        [OperationContract(IsOneWay = true)]
        void NumberOfUsers();

        [OperationContract(IsOneWay = true)]
        void SendUserList();
    }

    public interface IServerChatCallback
    {
        [OperationContract(IsOneWay = true)]
        void MsgCallback(string msg);

        [OperationContract(IsOneWay = true)]
        void AutCallBack(bool aut, string message);

        [OperationContract(IsOneWay = true)]
        void NumberOfUsersCallBack(int numOfUsers);

        [OperationContract(IsOneWay = true)]
        void UserListCallBack(string[] usersList);
    }

   

}
