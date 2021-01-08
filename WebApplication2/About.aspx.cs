using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KoiratDataAccess;

namespace WebApplication2
{
    public partial class About : Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Muuttaa koiran tiedot merkkijonoksi
        /// </summary>
        /// <returns>Merkkijonoksi muutettu koira tietoineen</returns>         
        public override string ToString()
        {
            Koirat koira = new Koirat();
            return koira.nimi + ", " + koira.sPuoli + ", " + koira.dob;
        }

        /// <summary>
        /// Hakee koiran tai koirien tiedot nimellä
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            using (KoiratDBEntities entities = new KoiratDBEntities())
            {
               string haettava = hakukenttanimi.Text;
               List<Koirat> koiria = entities.Koirats.ToList();//kaikki koirat
               List<Koirat> loytyneet = new List<Koirat>();//lista löytyneistä koirista

                foreach (Koirat koira in koiria)
                {
                    string s = haettava.ToLower();
                    string k = koira.nimi.ToLower();
                    if (k.Contains(s)) loytyneet.Add(koira);
                }
                //loytyneet.Sort();
                StringBuilder sb = new StringBuilder("");
                for (int i = 0; i < loytyneet.Count; i++)
                {
                    sb.Append(loytyneet[i].nimi.ToString() + ", " + loytyneet[i].sPuoli.ToString() + ", " + loytyneet[i].dob.ToString()+"|");//koko koira to string ei toimi?
                    sb.Append("\n");
                }
                Label1.Text = sb.ToString();

            }
 
        }

        /// <summary>
        /// Hakee tässä tietyllä ID:llä olevan koiran tiedot hakukenttään.
        /// Jos haku on vääränlainen, tulostaa hakukenttään "koiraa ei löydy"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                using (KoiratDBEntities entities = new KoiratDBEntities())
                {
                    int haettava = Int32.Parse(hakukentta.Text);
                    var koira = entities.Koirats.FirstOrDefault(k => k.id == haettava);
                    hakutulokset.Text = koira.nimi.ToString();
                }
            }
            catch
            {
                hakutulokset.Text = "Koiraa ei löydy";
            }
        }

    }
}