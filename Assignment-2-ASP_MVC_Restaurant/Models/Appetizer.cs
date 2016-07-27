namespace Assignment_2_ASP_MVC_Restaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appetizer")]
    public partial class Appetizer
    {
        public int AppetizerID { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerName { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerShortDesc { get; set; }

        [Required]
        [StringLength(100)]
        public string AppetizerLongDesc { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string ThumbUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string LargeUrl { get; set; }
    }
}
