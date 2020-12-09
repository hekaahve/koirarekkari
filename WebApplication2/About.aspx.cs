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
            string haku = hakukentta.Text;

        }
    }
}