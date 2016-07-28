namespace Assignment_2_ASP_MVC_Restaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Main_Course
    {
        public int Main_CourseID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Main_CourseName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string Main_CourseShortDesc { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Detailed Description")]
        public string Main_CourseLongDesc { get; set; }

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
