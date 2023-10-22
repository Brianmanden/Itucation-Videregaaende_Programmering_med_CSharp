﻿using Microsoft.EntityFrameworkCore;

namespace BushcraftBlog.Server.Models;

public class BushcraftBlogDBContext : DbContext
{
    public BushcraftBlogDBContext(DbContextOptions<BushcraftBlogDBContext> options) : base(options){}

    public DbSet<Document> Documents { get; set; }
}