namespace GeneralAccount.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fees_layer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        public int? index { get; set; }

        public int? Fees_Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? From { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? To { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? percentage { get; set; }

        public int? inputer { get; set; }

        public int? Auth { get; set; }

        public int? Auther { get; set; }

        public int? Method { get; set; }
    }
}
