using System;
using System.Collections.Generic;
using System.Linq;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int i = Int32.Parse(Label1.Text) + 1;
            Label1.Text = "tässä paljon asioita, tässä paljon asioita, tässä paljon asioita, \n" +
                "   tässä paljon asioita, tässä paljon asioita, \n" +
                "Moimoimoi";
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