﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Mashin_Master.context.constracts.Models
{
    internal class VedomRabItem 
    {
        /// <summary>
        /// индефикатор
        /// </summary>
        public Guid Id { get; set; }

        public Guid RabId { get; set; }

        /// <summary>
        /// Сумм
        /// </summary>
        public int Sum { get; set; }

        /// <summary>
        /// Кол-во
        /// </summary>
        public int Cound { get; set; }


    }
}
