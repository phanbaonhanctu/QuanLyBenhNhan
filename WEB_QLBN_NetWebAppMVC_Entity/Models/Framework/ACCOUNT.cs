namespace AspWebMvc.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string passwd { get; set; }
    }
}
