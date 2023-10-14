using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Mashin_Master.context.constracts.Models
{
    internal class Сonsumable : BaseAuditEntity
    {
        /// <summary>
        /// имя запчасти
        /// </summary>
        public string NameMeh { get; set; } = string.Empty;

        /// <summary>
        /// Штук
        /// </summary>
        public string Pieces { get; set; } = string.Empty;

        /// <summary>
        /// Цена
        /// </summary>
        public int Price { get; set; }
    }
}
