using Microsoft.EntityFrameworkCore;

public class ThaysPContext : DbContext
{
    public ThaysPContext(DbContextOptions<ThaysPContext> options) : base(options)
    {
    }

    public DbSet<ClienteModel> Clientes { get; set; }
    /*
    public DbSet<Treino> Treinos { get; set; }
    public DbSet<Exercicio> Exercicios { get; set; }
    public DbSet<Aula_Coletiva> Aulas { get; set; }
    public DbSet<Plano> Planos { get; set; }
    public DbSet<Instrutor> Instrutores { get; set; }
    public DbSet<Experiencia> Experiencias { get; set; }
    */

}