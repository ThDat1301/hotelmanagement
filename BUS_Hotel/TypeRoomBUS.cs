using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Hotel;
using DTO_Hotel;

namespace BUS_Hotel
{
    public class TypeRoomBUS
    {
        public static List<DTO_TypeRoom> listTypeRoom()
        {
            List<DTO_TypeRoom> list = new List<DTO_TypeRoom>();
            TypeRoomDAL listDisplay = new TypeRoomDAL();
            list = listDisplay.listTypeRoom();
            return list;
        }
        
    }
}
