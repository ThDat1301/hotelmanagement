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

            using (var db = new HotelDBEntities() )
            {
                var tb = from room in db.Rooms
                         select room;

                foreach( var i in tb)
                {
                    DTO_Room room = new DTO_Room();
                    room.Room_id = i.id;
                    room.Room_num = i.num.ToString();
                    room.Room_status = (bool)i.status;
                    room.Room_type = i.type;
                    room.Room_price = (float)i.price;
                    //room.Room_order_id = (int)i.orderID;
                    list.Add(room);
                }
            }

            return list;
        }

    }
}
