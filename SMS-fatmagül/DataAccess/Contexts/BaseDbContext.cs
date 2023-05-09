﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts;

public class BaseDbContext:DbContext
{
    protected IConfiguration Configuration { get; set; } //appsettings kalsörü IConfiguration ile okunur???
    public DbSet<Student> Students { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Course> Courses { get; set; }

    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration)
        :base(dbContextOptions)
    {
        Configuration = configuration;
        Database.EnsureCreated(); //veri tabanında bununla ilgili bir tablo oluşturduğundan emin ol eğer oluşmamışsa git oluştur
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //buradakileri kullan veritabanı tabloları için??
    }
}

