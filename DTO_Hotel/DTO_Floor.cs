using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Floor
    {
        private int _Floor_id;
        private string _Floor_name;

        public int Floor_id
        {
            get { return _Floor_id; }
            set { _Floor_id = value; }
        }

        public string Floor_name
        {
            get { return _Floor_name; } 
            set { _Floor_name = value; }
        }

    }
}
