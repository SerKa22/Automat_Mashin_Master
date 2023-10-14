using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Mashin_Master.context.constracts.Models
{
    internal class Vedom : BaseAuditEntity
    {
        public Guid Autoid { get; set; }
        public Guid Castomerid { get; set; }

        /// <summary>
        /// список запчастей
        /// </summary>
        public List <VedomConsumItem> ConsumItems { get; set; }

        /// <summary>
        /// список работ
        /// </summary>
        public List <VedomRabItem> RabItems { get; set; }
>


    }
}
