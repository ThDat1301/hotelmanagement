using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class RoomDAL
    {
        public List<DTO_Room> listRoom()
        {
            List<DTO_Room> list = new List<DTO_Room>();

            using (var db = new HotelDB() )
            {
                var tb = from room in db.Rooms
                         select room;

                foreach( var i in tb)
                {
                    DTO_Room room = new DTO_Room();
                    room.Room_id = i.id;
                    room.Room_num = i.num.ToString();
                    room.Room_status = (bool)i.status;
                    room.Room_price = (float)i.price;
                    room.Room_floor_id = (int)i.floorId;
                    room.Room_type_id = (int)i.typeRoomId;
                    list.Add(room);
                }
            }

            return list;
        }

        public List<DTO_Room> listRoomByFloor(int floorId)
        {
            List<DTO_Room> list = new List<DTO_Room>();

            using (var db = new HotelDB())
            {
                var tb = from room in db.Rooms
                         where room.floorId == floorId
                         select room;

                foreach (var i in tb)
                {
                    DTO_Room room = new DTO_Room();
                    room.Room_id = i.id;
                    room.Room_num = i.num.ToString();
                    room.Room_status = (bool)i.status;
                    room.Room_price = (float)i.price;
                    room.Room_floor_id = (int)i.floorId;
                    room.Room_type_id = (int)i.typeRoomId;
                    list.Add(room);
                }
            }
            return list;
        }

        

    }
}
