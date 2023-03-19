using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;

namespace DAL_Hotel
{
    public class TypeRoomDAL
    {
        public List<DTO_TypeRoom> listTypeRoom()
        {
            List<DTO_TypeRoom> list = new List<DTO_TypeRoom>();
            using (var db = new HotelDB())
            {
                var tr = from typeroom in db.TypeRooms select typeroom;
                foreach (var r in tr) 
                {
                    DTO_TypeRoom typeroom = new DTO_TypeRoom();
                    typeroom.TypeRoom_id = r.id;
                    typeroom.TypeRoom_name = r.name;
                    list.Add(typeroom);
                }
            }
            return list;
        }
    }
}
