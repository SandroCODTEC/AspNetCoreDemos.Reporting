using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace  DevExpress.DemoData.Models {    
    [Table("Hierarchy")]
    public class Hierarchy {
        [Key]
        [Column("Countries.Id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Countries_Id { get; set; }

        [StringLength(255)]
        public string OfficialName { get; set; }

        [MaxLength(2147483647)]
        public byte[] BFlag { get; set; }

        [Key]
        [Column("SubRegions.Id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SubRegions_Id { get; set; }

        [StringLength(50)]
        public string SubRegion { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [Key]
        [Column("Regions.Id", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Regions_Id { get; set; }
    }
}
