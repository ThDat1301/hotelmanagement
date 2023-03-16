using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Hotel
{
    public class FloorDAL
    {
        public List<DTO_Floor> listFloor()
        {
            List<DTO_Floor> list = new List<DTO_Floor>();

            using (var db = new HotelDB())
            {
                var tb = from floor in db.Floors
                         select floor ;

                foreach (var i in tb)
                {
                    DTO_Floor floor = new DTO_Floor();
                    floor.Floor_id = i.id;
                    floor.Floor_name = i.name;
                    list.Add(floor);
                }
            }

            return list;
        }

    }
}
