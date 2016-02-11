namespace CoderCamps_SPA2.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoderCamps_SPA2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CoderCamps_SPA2.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);

            var user = userManager.FindByName("docodo19@gmail.com");
            if(user == null)
            {
                user = new ApplicationUser
                {
                    Email = "docodo19@gmail.com",
                    UserName = "docodo19@gmail.com",
                };
                userManager.Create(user, "Secret123!");
            }

            var companies = new Company[]
            {
                new Company
                {
                    Id = 1,
                    Name = "Coder Camps",
                    UserId = user.Id,
                },
                new Company
                {
                    Id = 2,
                    Name = "Coder For Rent",
                    UserId = user.Id,
                },
            };
            context.Companies.AddOrUpdate(companies);

            var contacts = new Contact[]
            {
                new Contact { Name = "Bob", Phone = "555-555-5555", CompanyId = 1, Id = 1 },
                new Contact { Name = "Bill", Phone = "555-555-5555", CompanyId = 1, Id = 2 },
                new Contact { Name = "Bauer", Phone = "555-555-5555", CompanyId = 1, Id = 3 },
                new Contact { Name = "Dave", Phone = "555-555-5555", CompanyId = 2, Id = 4 },
                new Contact { Name = "Derek", Phone = "555-555-5555", CompanyId = 2, Id = 5 },
                new Contact { Name = "Don", Phone = "555-555-5555", CompanyId = 2, Id = 6 },
            };
            context.Contacts.AddOrUpdate(contacts);

            var deals = new Deal[]
            {
                new Deal {
                    Id = 1, Name = "ASP.NET deal", CompanyId = 1,
                },
                new Deal {
                    Id = 2, Name = "Super Awesome Deal", CompanyId = 1,
                }
            };

            var dealContacts = new Deal_Contact[]
            {
                new Deal_Contact { DealId = 1, ContactId = 1 , Id = 1},
                new Deal_Contact { DealId = 1, ContactId = 2 , Id = 2},
                new Deal_Contact { DealId = 2, ContactId = 1 , Id = 3},
                new Deal_Contact { DealId = 2, ContactId = 2 , Id = 4},
                new Deal_Contact { DealId = 2, ContactId = 3 , Id = 5},
            };
            context.DealContacts.AddOrUpdate(dealContacts);
        }
    }
}
