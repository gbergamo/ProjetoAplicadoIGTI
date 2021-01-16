using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoAplicadoIGTI.Data.Entity;
using System;

namespace ProjetoAplicadoIGTI.Data.Configuration
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            throw new NotImplementedException();
        }
    }
}
