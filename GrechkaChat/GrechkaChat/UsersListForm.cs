using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrechkaChat.ServiceGrechkaChat;

namespace GrechkaChat
{
    public partial class UsersListForm : Form , IServiceChatCallback
    {

        ServiceChatClient client;

        public UsersListForm()
        {
            InitializeComponent();
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
            UsersListView.FullRowSelect = true;
            UsersListView.View = View.Details;
            UsersListView.Columns.Add("Пользователи онлайн:",250, HorizontalAlignment.Center);
            client.SendUserList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersListView.Items.Clear();
            client.SendUserList();
        }

        public void UserListCallBack(string[] usersList)
        {
            for (int i = 0; i < usersList.Length; i++)
            {
                var item = new ListViewItem(usersList[i]);
                UsersListView.Items.Add(item);
            }
        }

        public void MsgCallback(string msg)
        {
            throw new NotImplementedException();
        }

        public void AutCallBack(bool aut, string message)
        {
            throw new NotImplementedException();
        }

        public void NumberOfUsersCallBack(int numOfUsers)
        {
            throw new NotImplementedException();
        }
    }
}
