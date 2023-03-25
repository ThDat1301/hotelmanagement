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
        public List<DTO_Room> getRoom()
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
                    room.Room_floor_id = (int)i.floorId;
                    room.Room_type_id = (int)i.typeRoomId;
                    list.Add(room);
                }
            }

            return list;
        }

        public List<DTO_Room> getRoomByFloor(int floorId)
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
                    room.Room_floor_id = (int)i.floorId;
                    room.Room_type_id = (int)i.typeRoomId;
                    list.Add(room);
                }
            }
            return list;
        }

        public bool addRoom(DTO_Room r)
        {
            try
            {
                Room room = new Room();                
                room.num = int.Parse(r.Room_num);
                room.status = r.Room_status;
                /*room.orderID = r.Room_order_id;*/
                room.floorId = r.Room_floor_id;
                room.typeRoomId = r.Room_type_id;
                HotelDB context = new HotelDB();
                context.Rooms.Add(room);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool updateRoom(DTO_Room r, int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var room = context.Rooms.FirstOrDefault(i => i.id == id);
                room.num = int.Parse(r.Room_num);
                room.status = r.Room_status;
/*                room.orderID = r.Room_order_id;*/
                room.floorId = r.Room_floor_id;
                room.typeRoomId = r.Room_type_id;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool removeRoom(int id)
        {
            try
            {
                HotelDB context = new HotelDB();
                var room = context.Rooms.FirstOrDefault(i => i.id == id);
                context.Rooms.Remove(room);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
