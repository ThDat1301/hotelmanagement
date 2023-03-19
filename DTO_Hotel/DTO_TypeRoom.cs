using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_TypeRoom
    {
        private int _TypeRoom_id;
        private string _TypeRoom_name;

        public int TypeRoom_id
        {
            get { return _TypeRoom_id; }
            set { _TypeRoom_id = value; }
        }

        public string TypeRoom_name
        {
            get { return _TypeRoom_name; }
            set { _TypeRoom_name = value; }
        }
    }
}
