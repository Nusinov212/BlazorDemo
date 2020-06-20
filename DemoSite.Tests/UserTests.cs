using DemoSite.Server.Controllers;
using Microsoft.EntityFrameworkCore;
using SqlServer;
using System;
using System.Linq;
using Xunit;

namespace DemoSite.Tests
{
    public class UserTests
    {
        [Fact]
        public void GetUserListTest()
        {
            var options = new DbContextOptionsBuilder<DemoContext>()
       .UseInMemoryDatabase(databaseName: "MovieListDatabase")
       .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new DemoContext(options))
            {
                context.Users.Add(new User { UserId = 1, UserName = "test" });
                context.SaveChanges();
            }
            using (var context = new DemoContext(options))
            {
                UserDetailsController controller = new UserDetailsController(context);
                var users = controller.ListUsers();
                Assert.Single(users);
            }
        }
    }
}
