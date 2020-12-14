using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class About : Page
    {
        Koira musti = new Koira("Musti", "26.10.2010", "uros");
        Koira nasse = new Koira("Nasse", "10.1.2004", "narttu");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(Label1.Text) + 1;
            Label1.Text = i.ToString();//muuta lisäämään asioita
        }

        /// <summary>
        /// Hakee hakukentästä asioita. Tässä tapauksessa ottaisi hakukentästä syötetyn
        /// hakulausekkeen ja hakisi tietokannasta halutut asiat kuten 
        /// koirien tiedot tms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            //lisää nyt hakukenttään vain koiran tostringinä
            hakukentta.Text = musti.toString();
        }


        public class Koira
        {
            private string nimi;
            private string dob;
            private string sPuoli;

            /// <summary>
            /// Alustaa koiran tiedot
            /// </summary>
            /// <param name="enimi"> koiran etunimi</param>
            /// <param name="syntAika">koiran syntymäaika</param>
            /// <param name="sukupuoli">koiran sukupuoli</param>
            public Koira(string enimi, string syntAika, string sukupuoli)
            {
                this.nimi = enimi;
                this.dob = syntAika;
                this.sPuoli = sukupuoli;
            }

            /// <summary>
            /// Muuttaa Koira-olion merkkijonoksi
            /// </summary>
            /// <returns></returns>
            public String toString()
            {
                return nimi +" |"+ dob + " |" + sPuoli;
            }
      
        }

        public static void main()
        {
            //

        }
    }
}