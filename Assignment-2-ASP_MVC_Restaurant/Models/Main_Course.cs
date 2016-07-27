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
        public string Main_CourseName { get; set; }

        [Required]
        [StringLength(50)]
        public string Main_CourseShortDesc { get; set; }

        [Required]
        [StringLength(100)]
        public string Main_CourseLongDesc { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string ThumbUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string LargeUrl { get; set; }
    }
}
