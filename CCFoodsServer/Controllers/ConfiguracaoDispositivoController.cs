using CCFoodsServer.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCFoodsServer.Controllers
{
    public class ConfiguracaoDispositivoController : ApiController
    {
        private ConfiguracaoDispositivoDAL configuracaoDispositivoDAL = new ConfiguracaoDispositivoDAL();

        [Route("dispositivos/configuracao")]
        public long Get(string eMail)
        {
            return (long)configuracaoDispositivoDAL.Insert(eMail).ConfiguracaoDispositivoId;
        }
    }
}
