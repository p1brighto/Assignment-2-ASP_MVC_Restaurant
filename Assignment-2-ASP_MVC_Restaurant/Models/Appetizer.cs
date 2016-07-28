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
        [Display(Name = "Name")]
        public string AppetizerName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string AppetizerShortDesc { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Detailed Description")]
        public string AppetizerLongDesc { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }
    }
}
