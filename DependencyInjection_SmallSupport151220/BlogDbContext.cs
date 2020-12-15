using DependencyInjection_SmallSupport151220.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_SmallSupport151220
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
              : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
