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
    public partial class Form1 : Form, IServiceChatCallback
    {
        bool isConnected = false;

        ServiceChatClient client;
        private User user { get; set; }

        public string mb_context { get; private set; }
        public Message mesObj { get; private set; }

        public Form1()
        {
            InitializeComponent();

            chat.WordWrap = true;

            Random rand = new Random();
            User u = new User("");
            u.user_name = $"|{rand.Next(10, 99).ToString()}|";
            this.user = u;

            sender_button.Enabled = false;
            message_box.Enabled = false;

            chat.ScrollBars = ScrollBars.Vertical;

            NumberOfUsers.Text = "Людей онлайн:";
            NumberOfUsers.Visible = false;

            UsersOnlineView.Enabled = false;
            UsersOnlineView.Visible = false;

            AutentificationForm autForm = new AutentificationForm();
            autForm.ShowDialog();
            if (UserName.registeredUserName != null)
            {
                u.user_name = UserName.registeredUserName;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconectUser();
        }

        void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                user.id = client.Connect(user.user_name);

                sender_button.Enabled = true;
                message_box.Enabled = true;

                ConDiscButton.Text = "Отключиться";
                isConnected = true;

                NumberOfUsers.Visible = true;
                UsersOnlineView.Enabled = true;
                UsersOnlineView.Visible = true;
                client.NumberOfUsers();
            }
        }

        void DisconectUser()
        {
            if (isConnected)
            {
                client.Disconnect(user.id);
                client.NumberOfUsers();
                client = null;

                sender_button.Enabled = false;
                message_box.Enabled = false;

                ConDiscButton.Text = "Подключиться";
                isConnected = false;

                NumberOfUsers.Visible = false;
                UsersOnlineView.Enabled = false;
                UsersOnlineView.Visible = false;
            }
        }

        public void MsgCallback(string msg)
        {
            chat.AppendText($"{Environment.NewLine}{msg}{Environment.NewLine}");
        }

        public void AutCallBack(bool aut, string message)
        {
            throw new NotImplementedException();
        }

        public void NumberOfUsersCallBack(int numOfUsers)
        {
            NumberOfUsers.Text = $"Людей онлайн: {numOfUsers}";
        }

        private void message_box_TextChanged(object sender, EventArgs e)
        {
            this.mb_context = message_box.Text;
        }

        private void sender_button_Click(object sender, EventArgs e)
        {

            if (this.mb_context != null)
            {
                client.SendMsg(message_box.Text, user.id);

                message_box.Clear();
                this.mb_context = null;
            }

        }

        private void chat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {

                if (e.Modifiers == Keys.Shift)
                {
                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                    sender_button_Click(sender_button, null);
                }


            }

        }

        private void ConDiscButton_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                DisconectUser();
            }
            else
            {
                ConnectUser();
            }
        }

        public void UserListCallBack(string[] usersList)
        {
            throw new NotImplementedException();
        }

        private void UsersOnlineView_Click(object sender, EventArgs e)
        {
            UsersListForm ulForm = new UsersListForm();
            ulForm.Show();
        }
    }
}
