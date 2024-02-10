using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using inner.masterApi.Authorization.Roles;
using inner.masterApi.Authorization.Users;
using inner.masterApi.Tarefa;
using inner.masterApi.MultiTenancy;

namespace inner.masterApi.EntityFrameworkCore
{
    public class masterApiDbContext : AbpZeroDbContext<Tenant, Role, User, masterApiDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<inner.masterApi.Tarefa.Tarefa> Tarefas { get; set; }
        public DbSet<inner.masterApi.Treino.Treino> Treinos{ get; set; }
        public DbSet<inner.masterApi.Modalidade.Modalidade> Modalidades { get; set; }
        public DbSet<inner.masterApi.Atleta.Atleta> Atletas { get; set; }

        public masterApiDbContext(DbContextOptions<masterApiDbContext> options)
            : base(options)
        {
        }
    }
}
