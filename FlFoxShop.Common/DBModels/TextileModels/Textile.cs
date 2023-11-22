using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlFoxShop.Common.DBModels.TextileModels
{
    public class Textile : Product
    {
        /// <summary>
        /// Цвет
        /// </summary>
        public string? Color { get; set; } 

        /// <summary>
        /// Основа
        /// </summary>
        public string? TextileBase { get; set; }

        /// <summary>
        /// Описание рисунка
        /// </summary>
        public string? DrawingTextDescription { get; set; }
    }
}
