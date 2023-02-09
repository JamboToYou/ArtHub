using Microsoft.EntityFrameworkCore;

using ArtHub.Core;

namespace ArtHub.DAL;

public class ArtHubDbContext : DbContext
{
	#if DEBUG
	public DbSet<Example> Examples { get; set; } = null!;
	#endif

	public ArtHubDbContext(DbContextOptions<ArtHubDbContext> options) : base(options) { }
}
