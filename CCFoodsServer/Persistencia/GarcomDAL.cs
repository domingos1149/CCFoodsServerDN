using CCFoodsServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCFoodsServer.Persistencia
{
    public class GarcomDAL
    {
        private CCFoodsContext contexto = new CCFoodsContext();

        public IEnumerable<Garcom> GetAll()
        {
            return contexto.Garcons;
        }

        public void Insert(Garcom garcom)
        {
            contexto.Garcons.Add(garcom);
            contexto.SaveChanges();
        }
    }
}