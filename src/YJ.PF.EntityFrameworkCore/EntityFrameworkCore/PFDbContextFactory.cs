using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using YJ.PF.Configuration;
using YJ.PF.Web;

namespace YJ.PF.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PFDbContextFactory : IDesignTimeDbContextFactory<PFDbContext>
    {
        public PFDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PFDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PFDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PFConsts.ConnectionStringName));

            return new PFDbContext(builder.Options);
        }
    }
}
