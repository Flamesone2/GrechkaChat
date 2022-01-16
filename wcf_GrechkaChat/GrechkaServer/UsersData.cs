using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrechkaServer
{
    class UsersData
    {
        public string login { get; set; }

        public string password { get; set; }
    }

    class JsonData
    {
        public UsersData[] userData { get; set; }
    }
}
