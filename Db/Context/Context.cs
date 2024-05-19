using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{

    public DbSet<Product> Tbl_product { get; set; }

    public DbSet<Color> Tbl_color { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=denali.liara.cloud,32885;Initial Catalog=myDB;User Id=sa;Password=cKFAtD08euUd7tHk83HUtQqj;MultipleActiveResultSets=true;TrustServerCertificate=true");
    }

    //dotnet tool install --global dotnet-ef
    
}