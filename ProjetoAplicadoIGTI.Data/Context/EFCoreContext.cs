using Microsoft.EntityFrameworkCore;

namespace ProjetoAplicadoIGTI.Data.Context
{
    public class EFCoreContext : DbContext
    {
        public EFCoreContext()
        {

        }

        public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
        {

        }
    }
}
