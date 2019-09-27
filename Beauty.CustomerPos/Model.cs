using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty.CustomerPos
{
    public class Customer
    {
        public string CT_ID { get; set; }
        public string CARDID { get; set; }
        public string FULLNAME { get; set; }
        public string ADDR_ROW1 { get; set; }
        public string ADDR_ROW2 { get; set; }
        public string ADDR_PROVINCE { get; set; }
        public string ADDR_ZIPCODE { get; set; }
        public string ADDR_MOBILE { get; set; }
        public string SEX { get; set; }
        public DateTime BIRTHDATE { get; set; }
    }
}
