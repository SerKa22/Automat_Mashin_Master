using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Mashin_Master.context.constracts.Models
{
    internal class Rab : BaseAuditEntity
    {
        /// <summary>
        /// имя работы
        /// </summary>
        public string NameRab { get; set; } = string.Empty;

        /// <summary>
        /// Штук
        /// </summary>
        public string Pieces { get; set; } = string.Empty;

        /// <summary>
        /// Цена
        /// </summary>
        public int Price
        {
            get; set;
        }
}
