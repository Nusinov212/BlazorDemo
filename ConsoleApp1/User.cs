using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
    public class UserContext  : DbContext
    {
        public DbSet<User> Users { get; set; }

      //  protected override void OnConfiguring(DbContextOptionsBuilder options)
          //  => options.("Data Source=Demo.db");
    }

    public class User
    {
        [Key]
        public int BlogId { get; set; }
        public string Url { get; set; }

    }

}