using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Identityscafollingapp.Data
{
    public class IdentityscafollingappContext(DbContextOptions<IdentityscafollingappContext> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
