using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Repository
{
    public class DbInitializer : IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManger;
        private readonly ApplicationDbContext _Context;

        public DbInitializer(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManger, ApplicationDbContext Context)
        {
            _roleManager = roleManager;
            _userManger = userManger;
            _Context = Context;
        }

        public void Initialize()
        {
        try
            {
                if (_Context.Database.GetPendingMigrations().Count()>0)
                {
                    _Context.Database.Migrate();
                }
            }
     catch (Exception) 
            {
                throw;
            }
            if (_Context.Roles.Any(x => x.Name == "Admin")) return;
            _roleManager.CreateAsync(new IdentityRole("Manager")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Customer")).GetAwaiter().GetResult();

            var User = new ApplicationUser()
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
            }



        }

    }
}
