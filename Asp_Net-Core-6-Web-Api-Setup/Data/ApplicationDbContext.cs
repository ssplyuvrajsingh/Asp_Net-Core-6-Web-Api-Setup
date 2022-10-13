using Asp_Net_Core_6_Web_Api_Setup.Data;
using Microsoft.EntityFrameworkCore;

namespace Dot6.API.Crud.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<CrudTable> CrudTables { get; set; }
}
