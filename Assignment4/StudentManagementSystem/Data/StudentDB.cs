using Microsoft.EntityFrameworkCore;
public class StudentDB: DbContext {

    public DbSet<Student> Students {get; set;}

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data source=Studentdata.db");
    }
}