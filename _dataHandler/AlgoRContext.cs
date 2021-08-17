using Microsoft.EntityFrameworkCore;

public  class AlgoRContext: DbContext{

    public AlgoRContext(DbContextOptions options) : base(options){
        
    }
    public DbSet<Product> products{ get; set; }
    
}