namespace Aplikacja.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class DatabaseContext:DbContext{
    public DbSet<UserModel>Users{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>optionsBuilder.UseSqlite(@"Data Source= F:\code\proj_pz2\pz2_proj\Aplikacja\Baza.db");
}