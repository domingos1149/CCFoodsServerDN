using CCFoodsServer.Models;
using CCFoodsServer.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCFoodsServer.Controllers
{
    public class GarcomController : ApiController
    {
        private GarcomDAL garcomDAL = new GarcomDAL();

        // GET: api/Garcom
        [Route("garcons/todos")]
        public IEnumerable<Garcom> Get()
        {
            return garcomDAL.GetAll();
        }

        [Route("garcom/insert")]
        public void PostInsertGarcom(Garcom garcom)
        {
            garcom.OperacaoSincronismo = Models.Enums.OperacaoSincronismo.Sincronizado;
            garcomDAL.Insert(garcom);
        }
    }
}
