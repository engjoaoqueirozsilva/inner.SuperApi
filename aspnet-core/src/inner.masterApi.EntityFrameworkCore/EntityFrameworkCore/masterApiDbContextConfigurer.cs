using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace inner.masterApi.EntityFrameworkCore
{
    public static class masterApiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<masterApiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<masterApiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
