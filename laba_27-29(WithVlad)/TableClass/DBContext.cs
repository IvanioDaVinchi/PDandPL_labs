using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace laba_27_29_WithVlad_
{
    class FlowerContext : DbContext
    {
        public FlowerContext() : base("FlowersShopConnection")
        { }

        public DbSet<Flowers> Flowers { get; set; }
        public DbSet<Sells> Sells { get; set; }
        public DbSet<FlowersInShop> FlowersInShop { get; set; }
    }
}
