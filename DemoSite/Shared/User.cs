using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace DemoSite.Shared
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

    }

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

    }
}
