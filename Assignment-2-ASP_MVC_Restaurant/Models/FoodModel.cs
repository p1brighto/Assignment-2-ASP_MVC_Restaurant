namespace Assignment_2_ASP_MVC_Restaurant.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodModel : DbContext
    {
        public FoodModel()
            : base("name=FoodModel")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodItem> FoodItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .Property(e => e.FoodType)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.FoodItems)
                .WithRequired(e => e.Food)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.FoodItemName)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.FoodType)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.ShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.LongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);
        }
    }
}
