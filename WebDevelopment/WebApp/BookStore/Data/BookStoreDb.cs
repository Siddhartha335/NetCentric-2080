using Microsoft.EntityFrameworkCore;
public class BookStoreDB: DbContext {

    public DbSet<Author> Authors {get; set;}
    public DbSet<Book> Books {get; set;}

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data source=BookStore.db");
    }
}

// dotnet tool install dotnet-ef --global