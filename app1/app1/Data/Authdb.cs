using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace app1.Data
{
    public class Authdb : IdentityDbContext<IdentityUser>
    {
        public Authdb(DbContextOptions options) : base(options)
        {

        }
    }
}
