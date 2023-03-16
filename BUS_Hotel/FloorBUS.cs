using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class FloorBUS
    {
        public static List<DTO_Floor> listFloor()
        {
            List<DTO_Floor> list = new List<DTO_Floor>();
            FloorDAL listDisplay = new FloorDAL();
            list = listDisplay.listFloor();
            return list;
        }
    }
}
