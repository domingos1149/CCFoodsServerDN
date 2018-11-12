using CCFoodsServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CCFoodsServer.Persistencia
{
    public class CCFoodsContext : DbContext
    {
        public CCFoodsContext() : base("CCFoods_CS")
        {

        }


        public DbSet<Garcom> Garcons { get; set; }

        public DbSet<ConfiguracaoDispositivo> ConfiguracoesDispositivos { get; set; }
    }
}