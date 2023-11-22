using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlFoxShop.Common.DBModels.TextileModels
{
    public class TextileType
    {
        public long Id { get; set; }

        public required string Title { get; set; }
    }
}
