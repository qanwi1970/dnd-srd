using System.Data.Entity.Migrations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SrdReference.Infrastructure;

namespace SrdReference.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var user = new ApplicationUser
            {
                UserName = "SuperPowerUser",
                Email = "qanwi1970@gmail.com",
                EmailConfirmed = true,
                FirstName = "Bill",
                LastName = "DeLude",
                City = "Thornton",
                State = "CO",
                Country = "USA"
            };

            manager.Create(user, "P@ssw0rd!");
        }
    }
}
