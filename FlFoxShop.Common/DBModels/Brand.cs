using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FlFoxShop.Common.DBModels
{
    public class Brand
    {
        public long Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        
        public string? Country { get; set; }
    }
}
