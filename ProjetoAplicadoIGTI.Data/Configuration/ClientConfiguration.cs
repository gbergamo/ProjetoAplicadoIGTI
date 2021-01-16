using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoAplicadoIGTI.Data.Entity;
using System;

namespace ProjetoAplicadoIGTI.Data.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            throw new NotImplementedException();
        }
    }
}
