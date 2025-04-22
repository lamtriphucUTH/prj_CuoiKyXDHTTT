using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CuoiKyXDHTTT.DTO
{
    class TransactionDTO
    {
        public int TransId { get; set; }  
        public ModelDTO Model { get; set; } 
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
