using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CuoiKyXDHTTT.DTO
{
    class MobileDTO
    {
        public ModelDTO Model { get; set; }
        public string IMEINO { get; set; }
        public string Status { get; set; }
        public DateTime Warranty { get; set; }
        public decimal Price { get; set; }
    }
}
