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
        /// <summary>
        /// Palauttaa kaikki koirat get-metodilla
        /// </summary>
        /// <returns>kaikki koirat</returns>
        public IEnumerable<Koirat> Get()
        {
            using(KoiratDBEntities entities = new KoiratDBEntities())
            {   //palautetaan lista kaikista koirista
                return entities.Koirats.ToList();
            }
        }

        /// <summary>
        /// Palauttaa yhden koiran halutulla ID:llä
        /// </summary>
        /// <returns>ID:n perusteella olevat koirat</returns>
        public Koirat Get(int ID)
        {
            using (KoiratDBEntities entities = new KoiratDBEntities())
            {   //palautetaan lista kaikista koirista
                return entities.Koirats.FirstOrDefault(e => e.id == ID);
            }
        }
    }
}