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
        public HttpResponseMessage Get(int ID)
        {
            using (KoiratDBEntities entities = new KoiratDBEntities())
            {   //palautetaan lista kaikista koirista
                var entity = entities.Koirats.FirstOrDefault(e => e.id == ID);

                if (entity != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, entity.id.ToString() + "," + entity.nimi + ", " + entity.dob + ", " + entity.sPuoli);
                }

                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Koira id:llä:" + ID.ToString() + " ei löydy");
                }
            }
        }

        /// <summary>
        /// Lisätään uusi koira tietokantaan
        /// </summary>
        /// <param name="koira">lisättävä koira</param>
        public HttpResponseMessage Post([FromBody]Koirat koira)
        {
            try
            {
                using (KoiratDBEntities entities = new KoiratDBEntities())
                {
                    entities.Koirats.Add(koira);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, koira);
                    message.Headers.Location = new Uri(Request.RequestUri + koira.id.ToString());
                    return message;
                }

            }
            catch (Exception ex)
            {
               return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);//jos joku menee pieleen
            }
        }



            //https://www.youtube.com/watch?v=BnJ8UI-tI-E&ab_channel=ProgrammingwithMosh mistä löytyisi ohje napin actioniin?
    }
}