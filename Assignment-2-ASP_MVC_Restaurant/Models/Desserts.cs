namespace Assignment_2_ASP_MVC_Restaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Desserts
    {
        [Key]
        public int DessertsID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string DessertsName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string DessertsShortDesc { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Detailed Desription")]
        public string DessertsLongDesc { get; set; }

        [Display(Name = "Price")]
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
