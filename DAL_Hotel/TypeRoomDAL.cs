using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;

namespace DAL_Hotel
{
    public class TypeRoomDAL
    {
        public List<DTO_TypeRoom> getTypeRoom()
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

        public bool addTypeRoom(DTO_TypeRoom tr)
        {
            try
            {
                TypeRoom t = new TypeRoom();
                t.id = tr.TypeRoom_id;
                t.name = tr.TypeRoom_name;
                HotelDB context = new HotelDB();
                context.TypeRooms.Add(t);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
            
        }

    }
}
