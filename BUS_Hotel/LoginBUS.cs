using DAL_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class LoginBUS
    {
        LoginDAL lg = new LoginDAL();
        public bool login(string username, string password) 
        {
            return lg.login(username, password);
        }
    }
}
