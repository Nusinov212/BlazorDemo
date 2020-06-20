using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new User { Url = "http://blogs.msdn.com/adonet" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var user = db.Users
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                user.Url = "https://devblogs.microsoft.com/dotnet";
              
                db.SaveChanges();

            }
        }
    }
}
