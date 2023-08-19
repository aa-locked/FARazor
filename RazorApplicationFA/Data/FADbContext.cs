using Microsoft.EntityFrameworkCore;
using RazorApplicationFA.Model.Doamin;

namespace RazorApplicationFA.Data
{
    public class FADbContext :DbContext
    {
        public FADbContext(DbContextOptions<FADbContext> dbContextOptions):base(dbContextOptions) 
        {

        }

        public DbSet<TFAMtrlGrp>  tFAMtrlGrp { get; set; }  
    }
}
