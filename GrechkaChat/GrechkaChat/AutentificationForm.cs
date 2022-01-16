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
    public partial class AutentificationForm : Form
    {
        public AutentificationForm()
        {
            InitializeComponent();
            groupBox1.Text = "Вход";
            InfoTextBox.Text = "Введите логин и пароль для входа!";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AutentificationForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {

        }

        private void SignUpBox_Click(object sender, EventArgs e)
        {
            if(/*regex*/ passwordBox.Text != null && passwordProofBox.Text != null && passwordProofBox.Text == passwordBox.Text)
            {

            }
        }
    }
}
