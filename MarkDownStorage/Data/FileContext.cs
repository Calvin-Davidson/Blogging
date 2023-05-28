using Blogging.Models;
using Microsoft.EntityFrameworkCore;

namespace Blogging.Data;

public sealed class FileContext : DbContext
{
    public DbSet<MarkdownFile> Files { get; private set; }
    
    public FileContext(DbContextOptions<FileContext> context) : base(context)
    {
        Files = Set<MarkdownFile>();
    }
}