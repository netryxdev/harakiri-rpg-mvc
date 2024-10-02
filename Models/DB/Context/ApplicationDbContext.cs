using Microsoft.EntityFrameworkCore;
using ninja_br_rpg_MVC.Models.DB.Entities;

namespace ninja_br_rpg_MVC.Models.DB.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<NinjaTipo> NinjaTipos { get; set; }
        public DbSet<UsuarioChar> UsuarioChars { get; set; }
        public DbSet<MissaoTipo> MissaoTipos { get; set; }
        public DbSet<Missao> Missoes { get; set; }
        public DbSet<Atributo> Atributos { get; set; }
        public DbSet<AtributoChar> AtributosChar { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<KekkeiGenkai> KekkeiGenkais { get; set; }
        public DbSet<JutsuTipo> JutsuTipos { get; set; }
        public DbSet<Jutsu> Jutsus { get; set; }
        public DbSet<ClanJutsu> ClanJutsus { get; set; }
        public DbSet<UsuarioCharJutsu> UsuarioCharJutsus { get; set; }
        public DbSet<Graduacao> Graduacoes { get; set; }
        public DbSet<Treinamento> Treinamentos { get; set; }
        public DbSet<Oponente> Oponentes { get; set; }
        public DbSet<TipoOponente> TipoOponentes { get; set; }
        public DbSet<OponenteAtributo> OponenteAtributos { get; set; }
        public DbSet<OponenteJutsu> OponenteJutsus { get; set; }
        public DbSet<GrindLimitador> GrindLimitadores { get; set; }
        public DbSet<MissaoPassivaUsuarioControle> MissaoPassivaUsuarioControles { get; set; }


    }
}
