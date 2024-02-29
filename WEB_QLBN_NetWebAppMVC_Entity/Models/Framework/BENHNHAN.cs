namespace AspWebMvc.Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHNHAN")]
    public partial class BENHNHAN
    {
        [Key]
        public Guid id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        [StringLength(10)]
        public string gender { get; set; }

        public DateTime? time { get; set; }

        [StringLength(50)]
        public string ppdt { get; set; }
    }
}
