using Microsoft.EntityFrameworkCore;

namespace crud.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) 
        {
            
        }
        
        
        
        
    }
}