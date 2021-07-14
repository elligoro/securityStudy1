using ApiTest.db;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiTest.DatabaseContext
{
    // https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0
    public class ApiTestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApiTestDbContext(DbContextOptions<ApiTestDbContext> options) : base(options) 
        { }
    }
}
