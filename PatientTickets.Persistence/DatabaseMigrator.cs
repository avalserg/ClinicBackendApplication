using Microsoft.EntityFrameworkCore;
using PatientTickets.Application.Abstractions.Persistence;

namespace PatientTickets.Persistence;

public sealed class DatabaseMigrator : IDatabaseMigrator
{
    private readonly ApplicationDbContext _dbApplicationDbContext;

    public DatabaseMigrator(ApplicationDbContext dbApplicationDbContext)
    {
        _dbApplicationDbContext = dbApplicationDbContext;
    }

    public Task MigrateAsync(CancellationToken cancellationToken)
    {
        return _dbApplicationDbContext.Database.MigrateAsync(cancellationToken);
    }

    public void Migrate()
    {
        _dbApplicationDbContext.Database.Migrate();
    }

    public IEnumerable<string> GetPendingMigrations()
    {
        return _dbApplicationDbContext.Database.GetPendingMigrations();
    }
}