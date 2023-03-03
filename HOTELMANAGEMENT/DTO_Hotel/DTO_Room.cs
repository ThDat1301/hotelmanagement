using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Room
    {
        private int _Room_id;
        private string _Room_num;
        private bool _Room_status;
        private string _Room_type;
        private float _Room_price;
        private int _Room_order_id;

        public int Room_id
        {
            get { return _Room_id; }
            set { _Room_id = value; }
        }

        public string Room_num
        {
            get { return _Room_num; }  
            set { _Room_num = value; }
        }

        public bool Room_status
        { 
            get { return _Room_status; }
            set { _Room_status = value; }
        }

        public string Room_type
        {
            get { return _Room_type; }
            set { _Room_type = value; } 
        }

        public float Room_price
        {
            get { return _Room_price; }
            set { _Room_price = value; }
        }

        public int Room_order_id
        {
            get { return _Room_order_id;}
            set { _Room_order_id = value;}
        }
    }
}
