namespace Automat_Mashin_Master.context.constracts.Models
{
    internal class Castomer : BaseAuditEntity
    {
        /// <summary>
        /// Кто сдал: ФИО
        /// </summary>
        public string NameAt { get; set; } = string.Empty;

        /// <summary>
        /// Телефон
        /// </summary>
        public string TelAt { get; set; } = string.Empty;

        /// <summary>
        /// Email
        /// </summary>
        public string EmailAt { get; set; } = string.Empty;
    }
}
