using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Merchant
    {
        public Guid Id { get; set; } = new Guid();
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string LupCountry { get; set; } = string.Empty;
        [Required]
        public string LupRSType { get; set; } = string.Empty;
        public string Connectivity { get; set; } = string.Empty;
        public string BusinessType { get; set; } = string.Empty;
        [Required]
        public string LupCardType { get; set; } = string.Empty;
        public string LupDiscMethod { get; set; } = string.Empty;
        [Required]
        public string LupAcctType { get; set; } = string.Empty;
        public string LupStmtDest { get; set; } = string.Empty;
        public string LupAuthType { get; set; } = string.Empty;
        public string LupDailyDisc { get; set; } = string.Empty;
        public string LupMCCType { get; set; } = string.Empty;
    }
}
