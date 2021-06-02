using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Garant.Models
{
    public class ApplicationContext:IdentityDbContext<User>
    {
        public DbSet<CommentsViewModel> CommentsViewModel { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Dialog> Dialogs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Finance> Finances { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            if(Database.EnsureCreated())
            {
                Article article = Article.GetDummyArticle();

                Articles.Add(article);
                SaveChanges();
            }
            
        }
    }
}
