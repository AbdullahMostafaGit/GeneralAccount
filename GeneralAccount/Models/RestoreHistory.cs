namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestoreHistory")]
    public partial class RestoreHistory
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal RestoreId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime RestoreDate { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string DBSize { get; set; }

        [StringLength(255)]
        public string BackupBath { get; set; }

        [StringLength(50)]
        public string RestoreTime { get; set; }
    }
}
