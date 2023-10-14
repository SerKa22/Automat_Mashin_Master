using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automat_Mashin_Master.context.constracts.Models
{
    /// <summary>
    /// базовый класс с аудитом
    /// </summary>
    public abstract class BaseAuditEntity
    {
        /// <summary>
        /// индефикатор
        /// </summary>
        public Guid id { get; set; }

        /// <summary>
        /// Когда создан
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Кем создан
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Когда изменен
        /// </summary
        public DateTimeOffset UpdateAt { get; set; }

        /// <summary>
        /// Кем изменен
        /// </summary
        public string UpdateBy { get; set; } = string.Empty;

        /// <summary>
        /// дата удаления
        /// </summary>
        public DateTimeOffset? DeleteAt { get; set; }

    }
}
