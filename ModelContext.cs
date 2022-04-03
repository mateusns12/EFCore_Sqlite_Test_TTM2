using Microsoft.EntityFrameworkCore;

namespace EntityFramework_class
{
    public class TestContext: DbContext
    {
        //public TestContext(DbContextOptions options) : base(options){}
        public DbSet<GRAFICOS_ID>? Grafico {get; set;}
        public DbSet<GRAFICOS_DADOS>? Dados {get; set;}
        public string DBPatch {get;}

        public TestContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var patch = Environment.GetFolderPath(folder);
            DBPatch = System.IO.Path.Join("testdb.db");
        }
        protected override void OnConfiguring (DbContextOptionsBuilder options)
           =>options.UseSqlite($"Data Source = {DBPatch}");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GRAFICOS_ID>().HasKey(c => new { c.GraficoID });
            modelBuilder.Entity<GRAFICOS_DADOS>()
            .HasOne(p => p.GRAFICOS_ID)
            .WithMany(b => b.Dados)
            .HasForeignKey(p => p.GraficoForeingKey);
            modelBuilder.Entity<GRAFICOS_DADOS>().HasKey(k => new {k.IndexID});
            modelBuilder.Entity<GRAFICOS_ID>().Property( a => a.GraficoID).ValueGeneratedOnAdd();
        }
    }
}