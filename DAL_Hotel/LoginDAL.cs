using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class LoginDAL
    {
        public bool login(string username, string password)
        {
            HotelDB context = new HotelDB();
            if (context.Staffs.FirstOrDefault(em => em.username == username && em.passwords == password) != null)
            {
                return true;    
            } 
            return false;
        }
    }
}
