using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlFoxShop.Common.DBModels
{
    /// <summary>
    /// Назначение продукта
    /// </summary>
    public class ProductPurpose
    {
        public long Id { get; set; }
        public required string Title { get; set; }
    }
}
