using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class AppleWatchContext : DbContext

    {
        public AppleWatchContext()
        {
        }
        public AppleWatchContext(DbContextOptions<AppleWatchContext> options)
            : base(options)
        {
        }

        public DbSet<AppleWatchItem> AppleWatchItems { get; set; }
    }
}

