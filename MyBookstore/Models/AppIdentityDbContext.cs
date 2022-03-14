using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*When setting up a new database, creating a new context file is the first step!*/
namespace MyBookstore.Models
{
    /*special inheritance here for username context file*/
    public class AppIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        /*Auto-generated this using a right-click*/
        public AppIdentityDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
