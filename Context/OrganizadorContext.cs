using Microsoft.EntityFrameworkCore;
using Desafio_API.Models;
using Desafio_API.Controllers;


namespace Desafio_API.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}