namespace Assignment_2_ASP_MVC_Restaurant.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantModel : DbContext
    {
        public RestaurantModel()
            : base("name=RestaurantConnection")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Beverages> Beverages { get; set; }
        public virtual DbSet<Desserts> Desserts { get; set; }
        public virtual DbSet<Main_Course> Main_Course { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerName)
                .IsUnicode(false);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerLongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.ThumbUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.LargeUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Beverages>()
                .Property(e => e.BeveragesName)
                .IsUnicode(false);

            modelBuilder.Entity<Beverages>()
                .Property(e => e.BeveragesShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Beverages>()
                .Property(e => e.BeveragesLongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Beverages>()
                .Property(e => e.ThumbUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Beverages>()
                .Property(e => e.LargeUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Desserts>()
                .Property(e => e.DessertsName)
                .IsUnicode(false);

            modelBuilder.Entity<Desserts>()
                .Property(e => e.DessertsShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Desserts>()
                .Property(e => e.DessertsLongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Desserts>()
                .Property(e => e.ThumbUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Desserts>()
                .Property(e => e.LargeUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Main_Course>()
                .Property(e => e.Main_CourseName)
                .IsUnicode(false);

            modelBuilder.Entity<Main_Course>()
                .Property(e => e.Main_CourseShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Main_Course>()
                .Property(e => e.Main_CourseLongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Main_Course>()
                .Property(e => e.ThumbUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Main_Course>()
                .Property(e => e.LargeUrl)
                .IsUnicode(false);
        }
    }
}
