using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineInterior.Models;
using System.Collections.Generic;

namespace OnlineInterior.Database
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Orderline> Orderlines { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Designer> Designer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Designer>().HasData(new Designer { UserName = "ingrid@ballong.se", DesignerId = 1 });

            modelBuilder.Entity<Project>().HasData(new Project { ProjectId = 1, ProjectName = "Kontoret", Creator = "wivianne@ballong.se", Orderlines = new List<Orderline>() });
            modelBuilder.Entity<Project>().HasData(new Project { ProjectId = 2, ProjectName = "Väntrum", Creator = "sven@ballong.se", Orderlines = new List<Orderline>() });
            modelBuilder.Entity<Project>().HasData(new Project { ProjectId = 3, ProjectName = "Caféet", Creator = "elias@ballong.se", Orderlines = new List<Orderline>() });

            modelBuilder.Entity<Orderline>().HasData(new Orderline
            {
                OrderLineId = 1,
                ProductName = "Bekant, skrivbord",
                Supplier = "IKEA",
                Info = "https://www.ikea.com/se/sv/p/bekant-skrivbord-sitt-sta-vit-s49022519/",
                Amount = 6,
                UnitPrice = 3495,
                ProjectId = 1
            });
            modelBuilder.Entity<Orderline>().HasData(new Orderline
            {
                OrderLineId = 2,
                ProductName = "Hattefjäll, kontorsstol",
                Supplier = "IKEA",
                Info = "https://www.ikea.com/se/sv/p/hattefjaell-kontorsstol-med-armstoed-smidig-svart-svart-s89305205/",
                Amount = 6,
                UnitPrice = 2995,
                ProjectId = 1
            });
            modelBuilder.Entity<Orderline>().HasData(new Orderline
            {
                OrderLineId = 3,
                ProductName = "Modulsoffa Play",
                Supplier = "AZ Design",
                Info = "https://www.azdesign.se/sv/articles/2.349.9258/modulsoffa-play-bredd-65-cm-djup-65-cm-valfri-farg-kladsel-stativ",
                Amount = 4,
                UnitPrice = 4220,
                ProjectId = 2
            });
            modelBuilder.Entity<Orderline>().HasData(new Orderline
            {
                OrderLineId = 4,
                ProductName = "Bord Monaco",
                Supplier = "AZ Design",
                Info = "https://www.azdesign.se/sv/articles/2.323.5144/bord-monaco-med-glasskiva-krom-dia-60-cm-hojd-545-cm",
                Amount = 1,
                UnitPrice = 1375,
                ProjectId = 2
            });
            modelBuilder.Entity<Orderline>().HasData(new Orderline
            {
                OrderLineId = 5,
                ProductName = "Konferensbord Xander",
                Supplier = "Gerdmans",
                Info = "https://www.gerdmans.se/kontor-och-konferens/stolar-bord/matsalsbord-pelarbord/konferensbord-xander-rund-skiva",
                Amount = 8,
                UnitPrice = 1825,
                ProjectId = 3
            });
            modelBuilder.Entity<Orderline>().HasData(new Orderline
            {
                OrderLineId = 6,
                ProductName = "Matsalsstol Pontus",
                Supplier = "Gerdmans",
                Info = "https://www.gerdmans.se/kontor-och-konferens/stolar-bord/matsalsstolar-skalstolar/matsalsstol-pontus-svart-galon-silver-stativ",
                Amount = 32,
                UnitPrice = 885,
                ProjectId = 3
            });
        }
    }
}
