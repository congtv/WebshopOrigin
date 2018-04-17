using System.Data.Entity;
using Webshop.Model.Models;

namespace Webshop.Data
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext() : base("WebshopDB")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategorys { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //Tạo phương thức tĩnh tạo mới dbcontext
        public static WebShopDbContext Create()
        {
            return new WebShopDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //TODO
            //builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            //builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}