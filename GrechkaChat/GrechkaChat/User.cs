using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrechkaChat
{
    class User
    {
        public string user_name { get; set; }

        public int id { get; set; }

        public User(string u_name)
        {
            this.user_name = u_name;
        }

        public void SendMessage(Message m)
        {

        }
    }
}
