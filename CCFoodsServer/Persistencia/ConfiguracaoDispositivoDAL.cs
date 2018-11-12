using CCFoodsServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCFoodsServer.Persistencia
{
    public class ConfiguracaoDispositivoDAL
    {
        private CCFoodsContext contexto = new CCFoodsContext();


        public ConfiguracaoDispositivo Insert(string eMail)
        {
            ConfiguracaoDispositivo cd = GetConfiguracaoDispositivo(eMail);

            if (cd == null)
            {
                cd = contexto.ConfiguracoesDispositivos.Add(new ConfiguracaoDispositivo() { Email = eMail });

                contexto.SaveChanges();
            }

            return cd;
        }


        private ConfiguracaoDispositivo GetConfiguracaoDispositivo(string email)
        {
            return contexto.ConfiguracoesDispositivos.Where(e => e.Email == email).FirstOrDefault();
        }
    }
}