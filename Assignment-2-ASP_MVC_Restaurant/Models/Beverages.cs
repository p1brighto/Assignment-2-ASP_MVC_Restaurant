namespace Assignment_2_ASP_MVC_Restaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Beverages
    {
        [Key]
        public int BeveragesID { get; set; }

        [Required]
        [StringLength(50)]
        public string BeveragesName { get; set; }

        [Required]
        [StringLength(50)]
        public string BeveragesShortDesc { get; set; }

        [Required]
        [StringLength(100)]
        public string BeveragesLongDesc { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string ThumbUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string LargeUrl { get; set; }
    }
}
