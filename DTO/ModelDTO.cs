using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_CuoiKyXDHTTT.DTO
{
    class ModelDTO
    {
        public int ModelId { get; set; }
        public CompanyDTO Company { get; set; }
        public string ModelNum { get; set; }
        public int AvailableQty { get; set; }
    }
}
