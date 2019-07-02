using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using YJ.PF.Authorization.Roles;
using YJ.PF.Authorization.Users;
using YJ.PF.MultiTenancy;

namespace YJ.PF.EntityFrameworkCore
{
    public class PFDbContext : AbpZeroDbContext<Tenant, Role, User, PFDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PFDbContext(DbContextOptions<PFDbContext> options)
            : base(options)
        {
        }
    }
}
