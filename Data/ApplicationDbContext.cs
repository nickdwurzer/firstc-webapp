namespace firstwebapp.Data;

using firstwebapp.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext :DbContext {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}

    public DbSet<BooksEntity> Books { get; }
}