namespace BlogSite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlogSite : DbContext
    {
        public BlogSite()
            : base("name=BlogSite")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Article)
                .HasForeignKey(e => e.ArticleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Articles)
                .Map(m => m.ToTable("Article_Tag").MapLeftKey("ArticleID").MapRightKey("TagID"));

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Articles)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Member>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Member)
                .HasForeignKey(e => e.MemberID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Members)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.RoleID);
        }
    }
}
