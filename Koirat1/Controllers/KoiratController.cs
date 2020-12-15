using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KoiratDataAccess;

namespace Koirat1.Controllers
{
    public class KoiratController : ApiController
    {
        public IEnumerable<Koirat> Get()
        {
            using(KoiratDBEntities entities = new KoiratDBEntities())
            {
                return entities.Koirats.ToList();
                //Jatka https://www.youtube.com/watch?v=nMGlaiNBbNU&ab_channel=kudvenkat kohdasta 8:45
            }
        }
    }
}