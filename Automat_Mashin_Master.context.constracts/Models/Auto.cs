using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_Mashin_Master.context.constracts.Models
{
    internal class Auto : BaseAuditEntity
    {
        /// <summary>
        /// модель
        /// </summary>
        public string ModelBy { get; set; } = string.Empty;
        /// <summary>
        /// Двигатель
        /// </summary>
        public string EngineBy { get; set; } = string.Empty;

        /// <summary>
        /// год выпуска
        /// </summary>
        public int YearAu { get; set; }

        /// <summary>
        /// пробег
        /// </summary>
        public int Mileage { get; set; }
    }
}
