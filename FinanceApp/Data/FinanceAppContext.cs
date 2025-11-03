using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceApp> options): base { }
    }
}
