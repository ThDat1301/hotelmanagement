using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class RoomBUS
    {
        public static List<DTO_Room> listRoom()
        {
            List<DTO_Room> list = new List<DTO_Room>();
            RoomDAL listDisplay = new RoomDAL();
            list = listDisplay.listRoom();
            return list;
        }

        public static List<DTO_Room> listRoomByFloor(int floorId)
        {
            List<DTO_Room> list = new List<DTO_Room>();
            RoomDAL listDisplay = new RoomDAL();
            list = listDisplay.listRoomByFloor(floorId);
            return list;

        }
    }
}
