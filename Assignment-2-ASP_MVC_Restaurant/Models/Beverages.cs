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
        [Display(Name = "Name")]
        public string BeveragesName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string BeveragesShortDesc { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Detailed Description")]
        public string BeveragesLongDesc { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Thumbnail Url")]
        public string ThumbUrl { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Large Image Url")]
        public string LargeUrl { get; set; }
    }
}
