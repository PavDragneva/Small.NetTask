namespace SmallTask.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class SmallTaskDbContext : IdentityDbContext<User>, ISmallTaskDbContext
    {
        public SmallTaskDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static SmallTaskDbContext Create()
        {
            return new SmallTaskDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}