using Microsoft.EntityFrameworkCore;

namespace DOT_API_CRUD.Models;

public class ProjectContext : DbContext
{
    public ProjectContext(DbContextOptions options) : base(options)
    {
    }
}