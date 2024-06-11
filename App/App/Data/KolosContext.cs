using System;
using System.Collections.Generic;
using App.Models;
//using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data;

public partial class KolosContext : DbContext
{
    public KolosContext()
    {
    }

    public KolosContext(DbContextOptions<KolosContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<CharacterTitle> Character_Titles { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
        
        
        modelBuilder.Entity<Item>().HasData(new List<Item>
        {
            new Item {
                Id = 1,
                Name = "Itemek1",
                Weight = 120
            },
            new Item {
                Id = 2,
                Name = "Itemek2",
                Weight = 100
            },
        });
        
        
        
        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>
        {
            new Backpack {
                CharacterId = 1,
                ItemId = 1,
                Amount = 10
            },
            new Backpack {
                CharacterId = 2,
                ItemId = 2,
                Amount = 5
            }
        });
        
        
        modelBuilder.Entity<Character>().HasData(new List<Character>
        {
            new Character {
                Id = 1,
                FirstName = "Max",
               LastName = "Galeziowski",
               CurrentWeight = 85,
               MaxWeight = 120
            },
            new Character {
                Id = 2,
                FirstName = "Krzys",
                LastName = "Zbys",
                CurrentWeight = 100,
                MaxWeight = 110
            }
        });
        
        

        
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
