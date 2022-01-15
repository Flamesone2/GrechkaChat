using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrechkaChat
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        private User user { get;  set; }
        public string mb_context { get;private set; }
        public Message mesObj { get;private set; }

        public Form1()
        {
            InitializeComponent();
            chat.WordWrap = true;
            Random rand = new Random();
            User u = new User("");
            u.user_name = rand.Next(10, 99).ToString();
            this.user = u;

        }

        void ConnectUser()
        {
            if (!isConnected)
            {
                ConDiscButton.Text = "Отключиться";
                isConnected = true;
            }
        }

        void DisconectUser()
        {
            if (isConnected)
            {
                ConDiscButton.Text = "Подключиться";
                isConnected = false;
            }
        }

        private void message_box_TextChanged(object sender, EventArgs e)
        {
            this.mb_context = message_box.Text;
        }

        private void sender_button_Click(object sender, EventArgs e)
        {
            
          /*  ChatClient net = new ChatClient();

            Message message = new Message(user.user_name,mb_context);

            net.StartConection(message);

            chat.Text += $"{net.answer}{Environment.NewLine}";

            //chat.Text += $"{user.user_name}:{Environment.NewLine}{mb_context}{Environment.NewLine}{Environment.NewLine}";

            message_box.Clear();*/
        }

        private void chat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter) 
            { 

                if(e.Modifiers == Keys.Shift)
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
    }
}
