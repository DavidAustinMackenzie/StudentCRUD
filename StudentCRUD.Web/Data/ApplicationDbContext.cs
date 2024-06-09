﻿using Microsoft.EntityFrameworkCore;
using StudentCRUD.Web.Models.Entities;

namespace StudentCRUD.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {    
        }

        public DbSet<Student> Students { get; set; }


    }
}