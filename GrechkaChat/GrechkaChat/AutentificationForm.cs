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
    public partial class AutentificationForm : Form, IServiceChatCallback
    {
        ServiceChatClient client;
        bool isReg;
        public AutentificationForm()
        {
            InitializeComponent();
            groupBox1.Text = "Вход";
            InfoTextBox.Text = "Введите логин и пароль для входа!";
            SignUpBox.Text = "Регистрация";
            passwordProofBox.Enabled = false;
            passwordProofBox.Visible = false;
            label3.Visible = false;
            isReg = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AutentificationForm_Load(object sender, EventArgs e)
        {
            client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (isReg)
            {
                if (/*regex*/ loginBox.Text != "" && passwordBox.Text != "")
                {
                    client.AutorisationCheck(loginBox.Text, passwordBox.Text);
                }
                else
                {
                    InfoTextBox.Text = "Поля пусты или введены некорректные данные!";
                }
            }
            else
            {
                if (/*regex*/ loginBox.Text != "" && passwordBox.Text != "" && passwordProofBox.Text != "" && passwordProofBox.Text == passwordBox.Text)
                {
                    client.RegistrationCheck(loginBox.Text, passwordBox.Text);
                }
                else
                {
                    InfoTextBox.Text = "Поля пусты или не совпадают пароли!";
                }
            }
        }

        private void SignUpBox_Click(object sender, EventArgs e)
        {

            if(isReg)
            {
                isReg = false;
                groupBox1.Text = "Регистрация";
                SignUpBox.Text = "Уже есть аккаунт";
                passwordProofBox.Enabled = true;
                passwordProofBox.Visible = true;
                label3.Visible = true;
            }
            else
            {
                isReg = true;
                groupBox1.Text = "Вход";
                SignUpBox.Text = "Регистрация";
                passwordProofBox.Enabled = false;
                passwordProofBox.Visible = false;
                label3.Visible = false;
            }

            
        }

        public void AutCallBack(bool aut, string message)
        {
            if (aut == true)
            {
                UserName.registeredUserName = loginBox.Text;
                InfoTextBox.Text = "Успех";
                Close();
            }
            else
            {
                InfoTextBox.Text = message;
            }
        }

        public void MsgCallback(string msg)
        {
            throw new NotImplementedException();
        }

        public void NumberOfUsersCallBack(int users)
        {
            throw new NotImplementedException();
        }

        public void UserListCallBack(string[] usersList)
        {
            throw new NotImplementedException();
        }

        private void AutentificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UserName.registeredUserName == null)
            {
                Application.Exit();
            }
        }
    }
}
