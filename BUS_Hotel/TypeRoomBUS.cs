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
        TypeRoomDAL dalTypeRoom = new TypeRoomDAL(); 
        public List<DTO_TypeRoom> getTypeRoom()
        {
            List<DTO_TypeRoom> list = new List<DTO_TypeRoom>();
            list = dalTypeRoom.getTypeRoom();
            return list;
        }

        public bool addTypeRoom(DTO_TypeRoom tr)
        {
            return dalTypeRoom.addTypeRoom(tr);
        }
        
    }
}
