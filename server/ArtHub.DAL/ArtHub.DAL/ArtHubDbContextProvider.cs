using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ArtHub.DAL;

public class ArtHubDbContextFactory : IDesignTimeDbContextFactory<ArtHubDbContext>
{
	public ArtHubDbContext CreateDbContext(string[] args)
	{
		var optionsBuilder = new DbContextOptionsBuilder<ArtHubDbContext>();
		optionsBuilder.UseNpgsql();

		return new ArtHubDbContext(optionsBuilder.Options);
	}
}